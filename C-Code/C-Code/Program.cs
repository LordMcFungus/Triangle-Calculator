using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Code
{
	class Program
	{
		static void Main(string[] args)
		{
# include <stdio.h>
# include <math.h>

#define PI 3.14159265358979323846

			double sinuscalc(double val);
			double coscalc(double val);
			double tancalc(double val);
			double asincalc(double val);
			double acoscalc(double val);
			double atancalc(double val);
			int helpfunction();

			int angabe(char eingabe[]);


			int main(void)
{
				// Einlesen der Variablen
				double x = 0.96514;
				double sinus = 0;
				double cosinus = 0;
				double tangens = 0;
				double asinus = 0;
				double acosinus = 0;
				double atangens = 0;
				double a = 0;
				double b = 0;
				double c = 0;
				double p = 0;
				double q = 0;
				double alpha = 0;
				double beta = 0;
				double gamma = 0;
				double hoa = 0;
				double hob = 0;
				double hoc = 0;
				double gege = 0;
				char input[] = "-r";
				int sa = 0;
				int sb = 0;
				int sc = 0;
				int wia = 0;
				int wib = 0;
				int wic = 0;
				int para = 0;
				int gs = 0;
				int ha = 0;
				int hb = 0;
				int hc = 0;
				int sp = 0;
				int sq = 0;
				char weiter[] = "yes";
				int calc = 0;
				double innr = 0;
				double pq = 0;

				do
				{
					a = 0;
					b = 0;
					c = 0;
					p = 0;
					q = 0;
					alpha = 0;
					beta = 0;
					gamma = 0;
					hoa = 0;
					hob = 0;
					hoc = 0;
					sa = 0;
					sb = 0;
					sc = 0;
					wia = 0;
					wib = 0;
					wic = 0;
					para = 0;
					ha = 0;
					hb = 0;
					hc = 0;
					gs = 0;
					sp = 0;
					sq = 0;
					calc = 0;
					innr = 0;
					pq = 0;
					helpfunction();
					// Angebe des Dreiecktypes
					do
					{
						printf(" Um welche Art von Dreieck handelt es sich: ");
						scanf("%s", &input);
						// Rechtwinkliges Dreieck
						if (strcmp(input, "help") == 0)
						{
							helpfunction();
						}
					} while (strcmp(input, "-r") != 0 && strcmp(input, "-gs") != 0 && strcmp(input, "-ad") != 0);
					if (strcmp(input, "-r") == 0)
					{
						gamma = 90;
						do
						{
							// Einlesen der Daten
							printf(" Welche Daten wollen Sie eingeben: ");
							scanf("%s", &input);
							para = angabe(input);
							//		printf ("%i \n",para);
							if (strcmp(input, "help") == 0)
							{
								helpfunction();
							}
							switch (para) // Einlesen der Daten
							{
								case 1:
									printf(" Seite A: ");
									scanf("%lf", &a);
									sa = 1;
									break;
								case 2:
									printf(" Seite B: ");
									scanf("%lf", &b);
									sb = 1;
									break;
								case 3:
									printf(" Seite C: ");
									scanf("%lf", &c);
									sc = 1;
									break;
								case 4:
									printf(" Winkel Alpha: ");
									scanf("%lf", &alpha);
									wia = 1;
									break;
								case 5:
									printf(" Winkel Beta: ");
									scanf("%lf", &beta);
									wib = 1;
									break;
								//				case 6: printf("Winkel Gamma: ");
								//						scanf("%lf",&gamma);
								//						wic = 1;
								//						break;
								//				case 7: printf(" Höhe a: ");
								//						scanf("%lf",&hoa);
								//						ha = 1;
								//						break;
								//				case 8: printf(" Höhe b: ");
								//						scanf("%lf",&hob);
								//						hb = 1;
								//						break;
								case 9:
									printf(" Höhe c: ");
									scanf("%lf", &hoc);
									hc = 1;
									break;
								case 10:
									printf(" Hypotenusenabschnitt p: ");
									scanf("%lf", &p);
									sp = 1;
									break;
								case 11:
									printf(" Hypotenusenabschnitt q: ");
									scanf("%lf", &q);
									sq = 1;
									break;
							}
						} while (strcmp(input, "go") != 0 || alpha >= 90 && beta >= 90);
						// falls p,q,oder c voehanden restlich seiten berechnen
						if (sa + sq == 2 && sp + sc + hc + sb == 0)
						{
							pq = q / 2;
							p = ((0 - q) / 2) + (sqrt(pow(pq, 2) + pow(a, 2)));
							c = p + q;
							if (c <= 0 || p <= 0)
							{
								p = (0 - q) / 2 - (sqrt(pow(pq, 2) + pow(a, 2)));
								c = q + p;
							}
							sc = 1;
							sp = 1;
						}
						else if (sb + sp == 2)
						{
							pq = p / 2;
							q = (0 - p) / 2 + (sqrt(pow(pq, 2) + pow(a, 2)));
							c = p + q;
							if (c <= 0 || q <= 0)
							{
								q = (0 - p) / 2 - (sqrt(pow(pq, 2) + pow(a, 2)));
								c = q + p;
							}
							sc = 1;
							sq = 1;
						}
						if (sa + sp == 2 && sc == 0 || sb + sq == 2 && sc == 0)
						{
							if (sa + sp == 2)
							{
								c = pow(a, 2) / p;
								sc = 1;
								if (sq == 0)
								{
									q = c - p;
									sq = 1;
								}

							}
							else
							{
								c = pow(b, 2) / q;
								sc = 1;
								if (sp == 0)
								{
									p = c - q;
									sp = 1;
								}

							}
						}
						if (sp + sq + sc >= 2)
						{
							if (sc == 0)
							{
								c = p + q;
								sc = 1;
							}
							else if (sp == 1)
							{
								q = c - p;
								sq = 1;
							}
							else
							{
								p = c - q;
								sp = 1;
							}
							if (hc == 0)
							{
								hoc = sqrt(p * q);
								hc = 1;
							}
							if (sa == 0)
							{
								a = sqrt(p * c);
								sa = 1;
							}
							if (sb == 0)
							{
								b = sqrt(q * c);
								sb = 1;
							}
						}
						// hehehe
						//Berechnung des Dreieckes
						if (wia == 1 || wib == 1)
						{

							// Winkel Alpha Überprüfen
							if (wia == 1)
							{
								// WinkelBeta Überprüfen
								if (wib == 1)
								{

								}
								// Beta berechnen, da Alph bekannt
								else
								{
									beta = gamma - alpha;
								}
							}
							// Winkel beta Überprüfen
							else if (wib == 1)
							{
								// Alpha berechnen, da Beta und Gamma bekannt
								alpha = gamma - beta;
							}
							// Seiten Überprüfen
							if (sa + sb + sc >= 1)
							{
								// Seite a Überprüfen
								if (sa == 1)
								{
									// Seite c Überprüfen
									if (sc == 0)
									{
										// Seite C mit sinus Alpha und a berechnen
										c = a / sinuscalc(alpha);
									}
									// Seite b Überprüfen
									if (sb == 0)
									{
										// Seite B berechnen mit Pytagoras
										b = sqrt(pow(c, 2) - pow(a, 2));
									}

								}
								// Falls a nicht vorhanden, B überprüfen.
								else if (sb == 1)
								{
									// c überprüfen
									if (sc == 0)
									{
										// C mit cosinus Alpha und b berechnen
										c = b / coscalc(alpha);
									}
									// a mit pythagoras berechnen
									a = sqrt(pow(c, 2) - pow(b, 2));
								}
								else
								{
									// A mit sinus und b mit pytagoras berechnen.
									a = c * sinuscalc(alpha);
									b = sqrt(pow(c, 2) - pow(a, 2));
								}
							}
							else if (hc + sp + sq == 2)
							{
								if (sp == 0)
								{
									p = pow(hc, 2) / q;
									c = p + q;
								}
								else
								{
									q = pow(hc, 2) / p;
									c = p + q;
								}
								a = sqrt(p * c);
								b = sqrt(q * c);
							}
							else if (hc == 1)
							{
								b = hoc / sinuscalc(alpha);
								a = hoc / sinuscalc(beta);
								c = sqrt(pow(a, 2) + pow(b, 2));
							}
							// Falls keine Seite und die Höhe vorhanden sind, nicht möglich
							else
							{
								printf(" Es sind zu wenig angaben vorhanden. \n");
								calc = 1;
							}

						}
						/**************************************************************
						HÖHE EINBAUEN WICHTIG !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
						***************************************************************/
						// Falls keine Winkel bekannt sind
						else
						{
							if (sa + sb + sc >= 2)
							{
								if (sa == 1)
								{
									if (sb == 1)
									{
										c = sqrt(pow(a, 2) + pow(b, 2));
									}
									else
									{
										b = sqrt(pow(c, 2) - pow(a, 2));
									}
								}
								else if (sb == 1)
								{
									a = sqrt(pow(c, 2) - pow(b, 2));
								}
								x = a / c;
								alpha = asincalc(x);
								beta = gamma - alpha;
							}
							else if (hc + sa + sb == 2)
							{
								if (sa == 0)
								{
									x = hoc / b;
									alpha = asincalc(x);
									beta = 90 - alpha;
									c = b / sinuscalc(beta);
									a = sqrt(pow(c, 2) - pow(b, 2));
								}
								else
								{
									x = hoc / a;
									//					printf("%lf \n",x);
									beta = asincalc(x);
									alpha = 90 - beta;
									c = a / sinuscalc(alpha);
									b = sqrt(pow(c, 2) - pow(a, 2));
								}
							}
							else
							{
								printf(" Es sind zu wenig angaben vorhanden. \n");
								calc = 1;
							}
						}
						if (hc + sp + sq < 3)
						{
							if (sp == 1 && sq == 0)
							{
								q = c - p;
								sq = 1;
							}
							else if (sq == 1 && sp == 0)
							{
								q = c - p;
								sp = 1;
							}
							if (sq + sp == 2 && hc == 0)
							{
								hoc = sqrt(p * q);
								hc = 1;
							}
							if (hc == 1)
							{
								p = pow(a, 2) / c;
								q = pow(b, 2) / c;
							}
							else
							{
								p = pow(a, 2) / c;
								q = pow(b, 2) / c;
								hoc = sqrt(p * q);
							}
						}
					}
					else if (strcmp(input, "-gs") == 0)
					{
						printf(" Welche beiden Seiten sind gleich: ");
						scanf("%s", &input);
						if (strcmp(input, "help") == 0)
						{
							helpfunction();
						}
						if (strcmp(input, "a,b") == 0)
						{
							gs = 1;
						}
						else if (strcmp(input, "a,c") == 0)
						{
							gs = 2;
						}
						else if (strcmp(input, "b,c") == 0)
						{
							gs = 3;
						}

						while (strcmp(input, "go") != 0)
						{
							// Einlesen der Daten
							printf(" Welche Daten wollen Sie eingeben: ");
							scanf("%s", &input);
							if (strcmp(input, "help") == 0)
							{
								helpfunction();
							}
							para = angabe(input);
							//		printf ("%i \n",para);
							switch (para)  //Einlesen der Daten
							{
								case 1:
									printf(" Seite A: ");
									scanf("%lf", &a);
									sa = 1;
									break;
								case 2:
									printf(" Seite B: ");
									scanf("%lf", &b);
									sb = 1;
									break;
								case 3:
									printf(" Seite C: ");
									scanf("%lf", &c);
									sc = 1;
									break;
								case 4:
									printf(" Winkel Alpha: ");
									scanf("%lf", &alpha);
									wia = 1;
									break;
								case 5:
									printf(" Winkel Beta: ");
									scanf("%lf", &beta);
									wib = 1;
									break;
								case 6:
									printf(" Winkel Gamma: ");
									scanf("%lf", &gamma);
									wic = 1;
									break;
								case 7:
									printf(" Ungültiger Parameter");
									break;
							}
						}

						// Überprüfen ob winkel vorhanden
						if (wia == 1 || wib == 1 || wic == 1)
						{
							// wnkel Alpha
							if (wia == 1)
							{
								// Überprüfen der glecichen Seiten und berechne der Winkel falls alpha vorhanden
								switch (gs)
								{
									case 1:
										beta = alpha;
										gamma = 180 - 2 * alpha;
										break;

									case 2:
										gamma = alpha;
										beta = 180 - 2 * alpha;
										break;

									case 3:
										beta = (180 - alpha) / 2;
										gamma = beta;
										break;
								}
							}

							else if (wib == 1)
							{
								// Überprüfen der glecichen Seiten und berechne der Winkel falls beta vorhanden
								switch (gs)
								{
									case 1:
										alpha = beta;
										gamma = 180 - 2 * beta;
										break;

									case 2:
										alpha = (180 - beta) / 2;
										gamma = alpha;
										break;

									case 3:
										gamma = beta;
										alpha = 180 - 2 * beta;
										break;
								}
							}
							else
							{
								// Überprüfen der glecichen Seiten und berechne der Winkel falls gamma vorhanden
								switch (gs)
								{
									case 1:
										alpha = (180 - gamma) / 2;
										beta = alpha;
										break;

									case 2:
										alpha = gamma;
										beta = 180 - 2 * gamma;
										break;

									case 3:
										beta = gamma;
										alpha = 180 - 2 * gamma;
										break;
								}
							}
							// Berechnen der Seiten
							if (sa + sb + sc >= 1)
							{
								// Überprüfen der gleichen Seiten
								switch (gs)
								{
									// Berechnen der nicht vorhandenen Seiten mit Sinussatz
									case 1:
										if (sa == 1)
										{
											b = a;
											sb = 1;
										}
										else if (sb == 1)
										{
											a = b;
											sa = 1;
										}
										if (sc == 1 && sa == 1)
										{

										}
										else if (sc == 1 && sa == 0)
										{
											a = (sinuscalc(alpha) * c) / sinuscalc(gamma);
											b = a;
										}
										else if (sc == 0 && sa == 1)
										{
											c = (sinuscalc(gamma) * a) / sinuscalc(alpha);
										}
										else
										{
											printf(" Es sind zu wenig Infromationen bekannt. \n");
											calc = 1;
										}
										break;

									// Berechnen der nicht vorhandenen Seiten mit Sinussatz
									case 2:
										if (sa == 1)
										{
											c = a;
											sc = 1;
										}
										else if (sc == 1)
										{
											a = c;
											sa = 1;
										}
										if (sb == 1 && sa == 1)
										{

										}
										else if (sb == 1 && sa == 0)
										{
											a = (sinuscalc(alpha) * b) / sinuscalc(beta);
											c = a;
										}
										else if (sb == 0 && sa == 1)
										{
											b = (sinuscalc(beta) * a) / sinuscalc(alpha);
										}
										else
										{
											printf(" Es sind zu wenig Infromationen bekannt. \n");
											calc = 1;
										}
										break;

									// Berechnen der nicht vorhandenen Seiten mit Sinussatz
									case 3:
										if (sb == 1)
										{
											c = b;
											sc = 1;
										}
										else if (sc == 1)
										{
											b = c;
											sb = 1;
										}
										if (sa == 1 && sb == 1)
										{

										}
										else if (sa == 1 && sb == 0)
										{
											b = (sinuscalc(beta) * a) / sinuscalc(alpha);
											c = b;
										}
										else if (sa == 0 && sb == 1)
										{
											a = (sinuscalc(alpha) * b) / sinuscalc(beta);
										}
										else
										{
											printf(" Es sind zu wenig Infromationen bekannt. \n");
											calc = 1;
										}
										break;
								}

							}
							else
							{
								printf(" Es sind nicht genügend informationen vorhanden. \n");
								calc = 1;
							}
						}
						// Falls keine Winkel vorhanden sind wird mit dem Cosinussatz weitergerechnet
						else if (sa + sb + sc >= 1)
						{
							if (sa == 1)
							{
								switch (gs)
								{
									case 1:
										b = a;
										// Seite c prüfen, da sie Notwendig ist
										if (sc == 1)
										{
											// Rest mit kosinussatz berechnen
											gamma = (pow(a, 2) + pow(b, 2) - pow(c, 2)) / (2 * a * b);
											gamma = acoscalc(gamma);
											alpha = (180 - gamma) / 2;
											beta = alpha;
										}
										else
										{
											printf(" Es sind zu wenig Informationen vorhanden. \n");
											calc = 1;
										}
										break;

									case 2:
										c = a;
										// Seite B Überprüfen, da Notwendig
										if (sb == 1)
										{
											// Rest mit kosinussatz berechnen
											beta = (pow(a, 2) + pow(c, 2) - pow(b, 2)) / (2 * a * c);
											beta = acoscalc(beta);
											alpha = (180 - beta) / 2;
											gamma = alpha;
										}
										else
										{
											printf(" Es sind zu wenig Informationen vorhanden. \n");
											calc = 1;
										}
										break;

									case 3:
										// B oder c müssen vorhanden sein, da man sonst zu wenig informationen hat
										if (sb == 1)
										{
											// Rest mit kosinussatz berechnen
											c = b;
											beta = (pow(a, 2) + pow(c, 2) - pow(b, 2)) / (2 * a * c);
											beta = acoscalc(beta);
											alpha = (180 - beta * 2);
											gamma = beta;
										}
										else if (sc == 1)
										{
											// Rest mit kosinussatz berechnen
											b = c;
											beta = (pow(a, 2) + pow(c, 2) - pow(b, 2)) / (2 * a * c);
											beta = acoscalc(beta);
											alpha = (180 - beta * 2);
											gamma = beta;
										}
										else
										{
											printf(" Es sind zu wenig Informationen vorhanden. \n");
											calc = 1;
										}
										break;

								}
							}
							else if (sb == 1)
							{
								switch (gs)
								{
									case 1:
										// C überprüfen, da notwendig
										if (sc == 1)
										{
											// Rest mit kosinussatz berechnen
											a = b;
											gamma = (pow(a, 2) + pow(b, 2) - pow(c, 2)) / (2 * a * b);
											gamma = acoscalc(gamma);
											alpha = (180 - gamma) / 2;
											beta = alpha;
										}
										else
										{
											printf(" Es sind zu wenig Informationen vorhanden. \n");
											calc = 1;
										}
										break;

									case 2:
										// C überprüen, da notwendig
										if (sc == 1)
										{
											// Rest mit kosinussatz berechnen
											a = c;
											beta = (pow(a, 2) + pow(c, 2) - pow(b, 2)) / (2 * a * c);
											beta = acoscalc(beta);
											alpha = (180 - beta) / 2;
											gamma = alpha;
										}
										else
										{
											printf(" Es sind zu wenig Informationen vorhanden. \n");
											calc = 1;
										}
										break;
									// Da A nicht vorhande ist, ist es nicht möglich 	
									case 3:
										printf(" Es sind zu wenig Informationen vorhanden. \n");
										calc = 1;
										break;
								}
							}
							// da a und b nicht vorhanden sind, ist es unmöglich
							else if (sc == 1)
							{
								printf(" Es sind zu wenig Informationen vorhanden. \n");
								calc = 1;
							}
						}
						else
						{
							printf(" Es sind zu wenig Informationene Vorhanden. \n");
							calc = 1;
						}
					}
					else if (strcmp(input, "-ad") == 0)
					{
						while (strcmp(input, "go") != 0)
						{
							// Einlesen der Daten
							printf(" Welche Daten wollen Sie eingeben: ");
							scanf("%s", &input);
							if (strcmp(input, "help") == 0)
							{
								helpfunction();
							}
							para = angabe(input);
							//		printf ("%i \n",para);
							switch (para) // Einlesen der Saten
							{
								case 1:
									printf(" Seite A: ");
									scanf("%lf", &a);
									sa = 1;
									break;
								case 2:
									printf(" Seite B: ");
									scanf("%lf", &b);
									sb = 1;
									break;
								case 3:
									printf(" Seite C: ");
									scanf("%lf", &c);
									sc = 1;
									break;
								case 4:
									printf(" Winkel Alpha: ");
									scanf("%lf", &alpha);
									wia = 1;
									break;
								case 5:
									printf(" Winkel Beta: ");
									scanf("%lf", &beta);
									wib = 1;
									break;
								case 6:
									printf(" Winkel Gamma: ");
									scanf("%lf", &gamma);
									wic = 1;
									break;
								case 7:
									printf(" Ungültiger Parameter");
									break;
							}
						}
						// Gegebene Daten Überprüfen
						if (wia + wib + wic == 1 && sa + sb + sc >= 2)
						{
							if (sa + sb + sc == 3)
							{
								// Sinussätze, da alle seiten vorhanden.
								if (wia == 1)
								{
									beta = (b * sinuscalc(alpha)) / a;
									beta = asincalc(beta);
									gamma = 180 - alpha - beta;
								}
								else if (wib == 1)
								{
									alpha = (a * sinuscalc(beta)) / b;
									alpha = asincalc(alpha);
									gamma = 180 - alpha - beta;
								}
								else
								{
									alpha = (a * sinuscalc(gamma)) / c;
									alpha = asincalc(alpha);
									beta = 180 - alpha - gamma;
								}
							}
							else if (wia == 1)
							{
								// Restliche seite mit cosinussatz berechene
								if (sb + sc == 2)
								{
									a = pow(b, 2) + pow(c, 2) - 2 * b * c * coscalc(alpha);
									a = sqrt(a);
									beta = (b * sinuscalc(alpha)) / a;
									beta = asincalc(beta);
									gamma = 180 - alpha - beta;
								}
								else if (sb == 1)
								{
									beta = (sinuscalc(alpha) * b) / a;
									beta = asincalc(beta);
									gamma = 180 - alpha - beta;
									c = pow(a, 2) + pow(b, 2) - 2 * a * b * coscalc(gamma);
									c = sqrt(c);
								}
								// seite c
								else
								{
									gamma = (sinuscalc(alpha) * c) / a;
									gamma = asincalc(gamma);
									beta = 180 - alpha - gamma;
									b = pow(a, 2) + pow(c, 2) - 2 * a * c * coscalc(beta);
									b = sqrt(b);
								}
							}
							else if (wib == 1)
							{
								if (sa + sc == 2)
								{
									// Restliche seite mit cosinussatz berechene
									b = pow(a, 2) + pow(c, 2) - 2 * a * c * coscalc(beta);
									b = sqrt(b);
									alpha = (a * sinuscalc(beta)) / b;
									alpha = asincalc(alpha);
									gamma = 180 - alpha - beta;
								}
								else if (sa == 1)
								{
									alpha = (a * sinuscalc(beta)) / b;
									alpha = asincalc(alpha);
									gamma = 180 - alpha - beta;
									c = pow(a, 2) + pow(b, 2) - 2 * a * b * coscalc(gamma);
									c = sqrt(c);
								}
								// seite c
								else
								{
									gamma = (c * sinuscalc(beta)) / b;
									gamma = asincalc(gamma);
									alpha = 180 - gamma - beta;
									a = pow(b, 2) + pow(c, 2) - 2 * b * c * coscalc(alpha);
									a = sqrt(a);
								}
							}
							// winkel gamma
							else
							{
								if (sa + sb == 2)
								{
									// Restliche seite mit cosinussatz berechene
									c = pow(a, 2) + pow(b, 2) - 2 * a * b * coscalc(gamma);
									c = sqrt(c);
									alpha = (a * sinuscalc(gamma)) / c;
									alpha = asincalc(alpha);
									beta = 180 - alpha - gamma;
								}
								else if (sa == 1)
								{
									alpha = (a * sinuscalc(gamma)) / c;
									alpha = asincalc(alpha);
									beta = 180 - alpha - gamma;
									b = pow(a, 2) + pow(c, 2) - 2 * a * c * coscalc(beta);
									b = sqrt(b);
								}
								// seite b
								else
								{
									beta = (b * sinuscalc(gamma)) / c;
									beta = asincalc(beta);
									alpha = 180 - gamma - beta;
									a = pow(b, 2) + pow(c, 2) - 2 * b * c * coscalc(alpha);
									a = sqrt(a);
								}
							}
						}
						else if (wia + wib + wic >= 2 && sa + sb + sc >= 1)
						{
							if (wia + wib + wic == 3)
							{

							}
							else
							{
								if (wia + wib == 2)
								{
									gamma = 180 - alpha - beta;

								}
								else if (wia + wic == 2)
								{
									beta = 180 - alpha - gamma;
								}
								else
								{
									alpha = 180 - beta - gamma;
								}

							}

							if (sa + sb + sc > 1)
							{
								if (sa + sb + sc == 2)
								{
									if (sa == 1)
									{
										if (sb == 1)
										{
											c = (sinuscalc(gamma) * a) / sinuscalc(alpha);
										}
										else
										{
											b = (sinuscalc(beta) * a) / sinuscalc(alpha);
										}
									}
									else if (sb == 1)
									{
										a = (sinuscalc(alpha) * b) / sinuscalc(beta);
									}
								}
								else
								{

								}
							}
							else if (sa == 1)
							{
								b = (sinuscalc(beta) * a) / sinuscalc(alpha);
								c = (sinuscalc(gamma) * a) / sinuscalc(alpha);
							}
							else if (sb == 1)
							{
								a = (sinuscalc(alpha) * b) / sinuscalc(beta);
								c = (sinuscalc(gamma) * b) / sinuscalc(beta);
							}
							else
							{
								a = (sinuscalc(alpha) * c) / sinuscalc(gamma);
								b = (sinuscalc(beta) * c) / sinuscalc(gamma);
							}
						}
						else if (sa + sb + sc == 3)
						{
							beta = (pow(a, 2) + pow(c, 2) - pow(b, 2)) / (2 * a * c);
							beta = acoscalc(beta);
							alpha = (pow(b, 2) + pow(c, 2) - pow(a, 2)) / (2 * b * c);
							alpha = acoscalc(alpha);
						}
						else
						{
							printf(" Es sind zu wenige Informationen vorhanden! \n");
							calc = 1;
						}

					}

					if (strcmp(input, "help") == 0 || calc == 1)
					{
					}
					else
					{
						system("cls");
						innr = a * b / (a + b + c);
						printf(" Seite A:		%lf \n Seite B:		%lf \n Seite C:		%lf \n Winkel Alpha:		%lf \n Winkel Beta:		%lf \n Winkel Gamma:		%lf \n P:			%lf \n Q:			%lf \n Höhe c:		%lf \n Innkreisradius:	%lf \n", a, b, c, alpha, beta, gamma, p, q, hoc, innr);
					}
					do
					{
						printf(" Möchten Sie fortfahren? [yes/no]");
						scanf("%s", &weiter);
					} while (strcmp(weiter, "yes") != 0 && strcmp(weiter, "no") != 0);
					system("cls");
				} while (strcmp(weiter, "yes") == 0);
				return 0;
			}

			// Überprüfung des Parameters
			int angabe(char eingabe[])
{
				if (strcmp(eingabe, "a") == 0)
				{
					return 1;
				}
				else if (strcmp(eingabe, "b") == 0)
				{
					return 2;
				}
				else if (strcmp(eingabe, "c") == 0)
				{
					return 3;
				}
				else if (strcmp(eingabe, "wa") == 0)
				{
					return 4;
				}
				else if (strcmp(eingabe, "wb") == 0)
				{
					return 5;
				}
				else if (strcmp(eingabe, "wc") == 0)
				{
					return 6;
				}
				else if (strcmp(eingabe, "ha") == 0)
				{
					return 7;
				}
				else if (strcmp(eingabe, "hb") == 0)
				{
					return 8;
				}
				else if (strcmp(eingabe, "hc") == 0)
				{
					return 9;
				}
				else if (strcmp(eingabe, "p") == 0)
				{
					return 10;
				}
				else if (strcmp(eingabe, "q") == 0)
				{
					return 11;
				}
				else
				{
					return 0;
				}
			}

			double sinuscalc(double val)
{
				double res;
				res = sin(val * PI / 180);
				return res;
			}

			double coscalc(double val)
{
				double res;
				res = cos(val * PI / 180);
				return res;
			}

			double tancalc(double val)
{
				double res;
				res = tan(val * PI / 180);
				return res;
			}

			double asincalc(double val)
{
				double res;
				res = asin(val);
				res = res * 180 / PI;
				return res;
			}

			double acoscalc(double val)
{
				double res;
				res = acos(val);
				res = res * 180 / PI;
				return res;
			}

			double atancalc(double val)
{
				double res;
				res = atan(val);
				res = res * 180 / PI;
				return res;
			}

			int helpfunction()
{
				printf("\n");
				printf(" ////////***********************************HELP***********************************\\\\\\\\\\\\\\\\\n");
				printf("\n");
				printf(" ---  Dreicksarten: \n");
				printf("\n");
				printf("   '-r'		Rechtwinkliges Dreieck: Gamma = 90 grad, c = hypotenuse\n");
				printf("   '-gs'	Gleichschenkliges Dreieck: zwei Winkel und deren Seiten sind gleich \n");
				printf("   '-ad'	Algemeines Dreieck: Keine speziellen Funktionen des Dreieckes vorhanden \n");
				printf("\n ****************************************************************************************\n \n");
				printf(" ---  Daten Parameter: \n");
				printf("\n");
				printf("   'a'		Seite a \n");
				printf("   'b'		Seite b \n");
				printf("   'c'		Seite c \n");
				printf("   'wa'		Winkel Alpha \n");
				printf("   'wb'		Winkel Beta \n");
				printf("   'wc'		Winkel Gamma (in einem rechtwinkligen Dreieck 90 grad) \n");
				printf("   'go'		Berechnet das Dreieck mit den eingegebenen Daten \n");
				printf("\n ****************************************************************************************\n \n");
				printf(" ---  Rechtwinkliges Dreieck: \n");
				printf("\n");
				printf("   'p'		Hypotenusenabschnitt p \n");
				printf("   'q'		Hypotenusenabschnitt q \n");
				printf("   'hc'		Höhe c \n");
				printf("\n ****************************************************************************************\n \n");
				printf(" ---  Gleichschenkliges Dreieck: \n");
				printf("\n");
				printf("   'a,b'	Seite a und b sind gleich \n");
				printf("   'a,c'	Seite a und c sind gleich \n");
				printf("   'b,c'	Seite b und c sind gleich \n");
				printf("\n ****************************************************************************************\n");
			}
		}
	}
}
