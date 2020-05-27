using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt1 {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
            labelTimeIn.Text = sliderHours.Value.ToString();
            labelName.Text = Form1.name;
            labelSurname.Text = Form1.surname;
            labelX.Text = ((Form1.location-1) % 4).ToString();
            labelY.Text = ((Form1.location-1) / 4).ToString();
            eventlog.Items.Add(new ListViewItem("Pomyslnie zalogowano jako " + labelName.Text + " " + labelSurname.Text));
        }

        private void sliderHours_Scroll(object sender, EventArgs e) {
            labelTimeIn.Text = sliderHours.Value.ToString();
        }

        private void labelDataNow_Click(object sender, EventArgs e) {

        }

        private void buttonGo_Click(object sender, EventArgs e) {

            int hours = sliderHours.Value;
            eventlog.Items.Add(new ListViewItem("Sprawdzam dane bazy przeciwpowodziowej dla terenu o współrzędnych x:" + labelX.Text + " y:" + labelY.Text));

            

            Sql baza = new Sql(); //Tworzenie połączenia z bazą
            eventlog.Items.Add(new ListViewItem("Pomyślnie połączono z bazą danych"));
            //Spisanie danych z bazy do terenu
            Terrain[][] teren = new Terrain[baza.maxX() + 1][];
            for (int i = 0; i <= baza.maxX(); i++) {
                teren[i] = new Terrain[baza.maxY() + 1];
                for (int j = 0; j <= baza.maxY(); j++) {

                    teren[i][j] = new Terrain(baza.GetTerrain(i, j));
                }
            }
            eventlog.Items.Add(new ListViewItem("Pobieranie danych terenu zakończone pomyslnie"));

            int id = Form1.location;

            int[] waternow = new int[17];
            foreach (int i in waternow) waternow[i] = 0;

            DateTime date = new DateTime(2019, 12, 31, 20, 00, 00);

            for (int i = 0; i < hours; i++) {
                date = date.AddHours(1);
                eventlog.Items.Add(new ListViewItem("Sprawdzam poziom wody w dacie " + date.ToString()));
                waternow = updateByHour(teren, baza, date, waternow);
                eventlog.Items.Add(new ListViewItem(alerts(id,waternow, date.Hour.ToString() )));
            }

        }

        static string alerts(int idL, int[] tab, string godz) {
            if (tab[idL] < 20) return ("O godzinie " + godz + " jesteś bezpieczny, poziom wody poniżej 20");
            if (tab[idL] > 20 && tab[idL] < 50) return  ("O godzinie " + godz + " możliwe będą lokalne podopienia, do 50");
            if (tab[idL] > 50 && tab[idL] < 100) return  ("O godzinie " + godz + " będzie powódź, mam nadzieję że umiesz pływać");
            if (tab[idL] > 100) return ("O godzinie " + godz + " będzie powódź, mam nadzieję że umiesz nurkować");
            else return "Nie powinienes nigdy zobaczyć tego błędu";

        }
        static int[] updateByHour(Terrain[][] teren, Sql baza, DateTime godz, int[] prevRain) {
            //start big boy

            

            int[] woda = new int[17];
            

            woda = baza.getRainfallOnDate(godz.ToString("yyy-MM-dd HH:mm:ss"));


            for (int i = 0; i < 17; i++) woda[i] += prevRain[i]; //dodaj deszcz z poprzedniej godziny


            for (int y = 0; y < baza.maxY() + 1; y++) {
                for (int x = 0; x < baza.maxX() + 1; x++) {


                    int[][] wodaTemp = new int[3][];
                    for (int i = 0; i < 3; i++) wodaTemp[i] = new int[3];

                    wodaTemp = teren[x][y].whereWaterGoes(teren[x][y].rainfallInLocation(woda[teren[x][y].getLocationID()])); //zwraca kierunek i poedzieloną wodę w tabeli [1][3] lub [3][3] // ale potwór xD


                    //tymczasowy cheat, co robić jak wylewa
                    if (teren[x][y].getLocationID() == 9 || teren[x][y].getLocationID() == 13) {
                        wodaTemp[0][0] = 0; wodaTemp[1][0] = 0; wodaTemp[2][0] = 0;
                    }
                    //koniec cheat

                    woda[teren[x][y].getLocationID()] = 0;

                    if (wodaTemp[0][0] != 0 || wodaTemp[1][0] != 0 || wodaTemp[2][0] != 0) {
                        woda[teren[x + wodaTemp[0][1]][y + wodaTemp[0][2]].getLocationID()] += wodaTemp[0][0];
                        woda[teren[x + wodaTemp[1][1]][y + wodaTemp[1][2]].getLocationID()] += wodaTemp[1][0];
                        woda[teren[x + wodaTemp[2][1]][y + wodaTemp[2][2]].getLocationID()] += wodaTemp[2][0];
                        //bool że robi od nowa

                    }


                }
            }
            //koniec big boy
            return woda;
        }//Zwraca stan wody po podanej godzinie na całej planszy

    }
}
