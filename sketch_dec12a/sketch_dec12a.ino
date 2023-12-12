long b1 = 0xFFA25D;
long b2 = 0xFF629D;// Yeşil renk için kullanılan U.K. kodu
long b3 = 0xFFE21D;// Mavi renk için kullanılan U.K. kodu
long b4= 0xFF22DD;// Sarı renk için kullanılan U.K. kodu
long b5 = 0xFF02FD;// Mor renk için kullanılan U.K. kodu
long b6 = 0xFFC23D;// Turkuaz renk için kullanılan U.K. kodu
long b7 = 0xFFE01F;// Beyaz renk için kullanılan U.K. kodu
long b8 = 0xFFA857;
long b9 = 0xFF906F;
long b0 = 0xFF9867;
long by = 0xFF18E7;
long ba = 0xFF4AB5;

#include <IRremote.h>
int RECV_PIN = 11;
IRrecv irrecv(RECV_PIN);
decode_results results;
void setup()
{
Serial.begin(9600);
irrecv.enableIRIn(); // IR alıcıyı başlatır.
for (int i=2;i<=8;i++) pinMode(i, OUTPUT);
}
void loop() {
if (irrecv.decode(&results)) {
Serial.println(results.value, HEX);
if (results.value==b1) bir();
if (results.value==b2) iki();
if (results.value==b3) uc();
if (results.value==b4) dort();
if (results.value==b5) bes();
if (results.value==b6) alti();
if (results.value==b7) yedi();
if (results.value==b8) sekiz();
if (results.value==b9) dokuz();
if (results.value==b0) sifir();
if (results.value==by) ilerisay();
if (results.value==ba) gerisay();
irrecv.resume(); // Sıradaki değeri algılar
}
}
void ilerisay(){
sifir(); delay(1000);
bir(); delay(1000);
iki(); delay(1000);
uc(); delay(1000);
dort(); delay(1000);
bes(); delay(1000);
alti(); delay(1000);
yedi(); delay(1000);
sekiz(); delay(1000);
dokuz(); delay(1000);
}
void gerisay(){
dokuz(); delay(1000);
sekiz(); delay(1000);
yedi(); delay(1000);
alti(); delay(1000);
bes(); delay(1000);
dort(); delay(1000);
uc(); delay(1000);
iki(); delay(1000);
bir(); delay(1000);
sifir(); delay(1000);
}
void sifir() {
digitalWrite(2, 0); //a
digitalWrite(3, 0); //b
digitalWrite(4, 0); //c
digitalWrite(5, 0); //d
digitalWrite(6, 0); //e
digitalWrite(7, 0); //f
digitalWrite(8, 1); //g
}
void bir() {
digitalWrite(2, 1); //a
digitalWrite(3, 0); //b
digitalWrite(4, 0); //c
digitalWrite(5, 1); //d
digitalWrite(6, 1); //e
digitalWrite(7, 1); //f
digitalWrite(8, 1); //g
}
void iki() {
digitalWrite(2, 0); //a
digitalWrite(3, 0); //b
digitalWrite(4, 1); //c
digitalWrite(5, 0); //d
digitalWrite(6, 0); //e
digitalWrite(7, 1); //f
digitalWrite(8, 0); //g
}
void uc() {
digitalWrite(2, 0); //a
digitalWrite(3, 0); //b
digitalWrite(4, 0); //c
digitalWrite(5, 0); //d
digitalWrite(6, 1); //e
digitalWrite(7, 1); //f
digitalWrite(8, 0); //g
}
void dort() {
digitalWrite(2, 1); //a
digitalWrite(3, 0); //b
digitalWrite(4, 0); //c
digitalWrite(5, 1); //d
digitalWrite(6, 1); //e
digitalWrite(7, 0); //f
digitalWrite(8, 0); //g
}
void bes() {
digitalWrite(2, 0); //a
digitalWrite(3, 1); //b
digitalWrite(4, 0); //c
digitalWrite(5, 0); //d
digitalWrite(6, 1); //e
digitalWrite(7, 0); //f
digitalWrite(8, 0); //g
}
void alti() {
digitalWrite(2, 0); //a
digitalWrite(3, 1); //b
digitalWrite(4, 0); //c
digitalWrite(5, 0); //d
digitalWrite(6, 0); //e
digitalWrite(7, 0); //f
digitalWrite(8, 0); //g
}
void yedi() {
digitalWrite(2, 0); //a
digitalWrite(3, 0); //b
digitalWrite(4, 0); //c
digitalWrite(5, 1); //d
digitalWrite(6, 1); //e
digitalWrite(7, 1); //f
digitalWrite(8, 1); //g
}
void sekiz() {
digitalWrite(2, 0); //a
digitalWrite(3, 0); //b
digitalWrite(4, 0); //c
digitalWrite(5, 0); //d
digitalWrite(6, 0); //e
digitalWrite(7, 0); //f
digitalWrite(8, 0); //g
}
void dokuz() {
digitalWrite(2, 0); //a
digitalWrite(3, 0); //b
digitalWrite(4, 0); //c
digitalWrite(5, 0); //d
digitalWrite(6, 1); //e
digitalWrite(7, 0); //f
digitalWrite(8, 0); //g
}
