#include <LiquidCrystal_I2C.h>

LiquidCrystal_I2C lcd  (0x27, 16, 2);
void setup(){ 
lcd.begin();
}

void loop() {

lcd.clear();
delay(1000);
lcd.setCursor(0, 0);
lcd.print("Tavuk Doner");
delay(1000);
lcd.setCursor(0, 1);
lcd.print("50 TL");
delay(1000);

for (int x = 1; x<= 5; x++){
  lcd.noBacklight();
  delay(500);
  lcd.backlight();
  delay(500);
}
}
