using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Projekt1 {
    public class Terrain {
        int x;
        int y;
        int locationID;
        int tiltDir;
        int tilt;
        int absRate, absCap, absNow, absOut;

        public Terrain(int[] record) {
            this.x = record[0];
            this.y = record[1];
            this.tilt = record[2];
            this.tiltDir = record[3];
            this.absRate = record[4];
            this.absCap = record[5];
            this.absNow = record[6];
            this.absOut = record[7];
            locationID = this.x + (this.y * 4) + 1;

        }
        public int getLocationID() {
            return locationID;
        }

        public int rainfallInLocation(int rainfall) {

            float preBilans = (float)rainfall - ((float)absRate * (1 - ((float)tilt / 90)));
            int bilans = (int)preBilans;
            int x = 0;

            if (bilans > 0) {
                float temp = (float)absNow - (float)absOut + ((float)absRate * (1 - ((float)tilt / 90)));
                absNow = (int)temp;
                //bilans = bilans - absOut - absNow;
                if (bilans < 0) bilans = 0;
                x += bilans;
            } else absNow = absNow - absOut + rainfall;

            if (absNow < 0) absNow = 0;
            if (absNow > absCap) {
                x += absCap - absNow;
                absNow = absCap;

            }

            return x;
        }

        public int[][] whereWaterGoes(int x) { //ogarnij to paskudztwo | dostaje wodę która ma być przekazana dalej, 
            int a;                      //zwraca tabele [1][3] albo [3][3], gdzie pierwsza wartosc to ilosc wody a druga na które
                                        //pole względem pochylenia (-x +x, -y +y)
                                        //cheat co robić jak tilt jest 0
            if (tilt == 0) {
                int[][] tab2 = new int[3][];
                for (int i = 0; i < 3; i++) {
                    tab2[i] = new int[3];

                    for (int j = 0; j < 3; j++) {
                        tab2[i][j] = 0;
                    }
                    tab2[0][0] = x;

                }
                return tab2;
            }
            if (tiltDir % 90 < 30 || tiltDir % 90 > 59) a = 1;
            else a = 3;


            int[][] tab = new int[3][];

            if (a == 1) {
                tab[0] = new int[3];

                int temp = (tiltDir + 30) / 90;
                if (temp == 4) temp = 0;
                tab[0][0] = x;

                //cheat, reszta pól ma zero
                tab[1] = new int[3];
                tab[2] = new int[3];
                tab[1][0] = 0;
                tab[1][1] = 0;
                tab[1][2] = 0;
                tab[2][0] = 0;
                tab[2][1] = 0;
                tab[2][2] = 0;
                //cheat end 


                switch (temp) {
                    case 0:
                        tab[0][1] = 1;
                        tab[0][2] = 0;
                        break;
                    case 1:
                        tab[0][1] = 0;
                        tab[0][2] = -1;
                        break;

                    case 2:
                        tab[0][1] = -1;
                        tab[0][2] = 0;
                        break;

                    case 3:
                        tab[0][1] = 0;
                        tab[0][2] = 1;
                        break;
                }


            } else {
                tab[0] = new int[3];
                tab[1] = new int[3];
                tab[2] = new int[3];

                tab[0][0] = (int)(100 - 66.33 * (((tiltDir % 90) - 30) / 15));
                tab[1][0] = (int)(33 * (((tiltDir % 90) - 30) / 10));
                tab[2][0] = 100 - tab[0][0] - tab[1][0];

                tab[0][0] = (tab[0][0] * x) / 100;
                tab[1][0] = (tab[1][0] * x) / 100;
                tab[2][0] = (tab[2][0] * x) / 100;

                int temp = (tiltDir - 30) / 90;

                switch (temp) {
                    case 0:
                        tab[0][1] = 1;
                        tab[0][2] = 0;
                        tab[1][1] = 1;
                        tab[1][2] = -1;
                        tab[2][1] = 0;
                        tab[2][2] = -1;
                        break;
                    case 1:
                        tab[0][1] = 0;
                        tab[0][2] = -1;
                        tab[1][1] = -1;
                        tab[1][2] = -1;
                        tab[2][1] = -1;
                        tab[2][2] = 0;
                        break;

                    case 2:
                        tab[0][1] = -1;
                        tab[0][2] = 0;
                        tab[1][1] = -1;
                        tab[1][2] = 1;
                        tab[2][1] = 0;
                        tab[2][2] = 1;
                        break;

                    case 3:
                        tab[0][1] = 0;
                        tab[0][2] = 1;
                        tab[1][1] = 1;
                        tab[1][2] = 1;
                        tab[2][1] = 1;
                        tab[2][2] = 0;
                        break;
                }
            }

            return tab;

        }

        void updateRainfall(int[] rainfall) {

            //sprawdź pole
            //sprawdź czy dostał coś z innych
            //oblicz ile leci dla niego
            //sprawdź wartość do następnych
            //go to next
        }
    }
}
