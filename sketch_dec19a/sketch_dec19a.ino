#include <LiquidCrystal_I2C.h>
LiquidCrystal_I2C lcd(0x27, 16, 2);
void setup() {
lcd.begin();
lcd.print("SICAKLIK");
}
void loop() {
int sensor = analogRead(A0);


float analog = sensor * 5.0;
analog = analog /1024.0;
float c = (analog - 0.5) * 10 +5 ;
lcd.setCursor(0, 1);
lcd.print(c);
lcd.setCursor(5, 1);
lcd.print("C");
}
