#include <LiquidCrystal.h>

LiquidCrystal lcd(3,4,5,6,8,9);
int button = 13;


byte Weapon[] = {
  B01000,
  B01000,
  B11111,
  B01010,
  B01100,
  B01000,
  B01110,
  B00000
};

byte Shep[] = {
  B00100,
  B01010,
  B01010,
  B01110,
  B00100,
  B00100,
  B01010,
  B10001
};

byte bullet[] = {
  B00000,
  B00000,
  B00000,
  B01110,
  B01001,
  B01110,
  B00000,
  B00000
};


void setup() {
  // put your setup code here, to run once:
  lcd.begin(16,2);
  lcd.clear();
  lcd.setCursor(0,2);
  lcd.createChar(1, Weapon);
  lcd.createChar(2, Shep);
  lcd.createChar(3, bullet);
  lcd.home();

  pinMode(button, INPUT_PULLUP);

  Serial.begin(9600);


}

void loop() {
  // put your main code here, to run repeatedly:
  lcd.clear();
  int count = 0;
  int pos2 = 0;
  int pos = 1;
  int i;
  while(true){
    for(i = 2; i < 16; i++){
      while(1){
        if(digitalRead(button) == LOW){
          delay(100);
            if(digitalRead(button) == LOW){
              if(pos == 1){
               pos = 0;
             }
              else{
               pos = 1;
              }
          }
        }
    
        if(i == 15 && pos == pos2){
          lcd.clear();
          lcd.setCursor(1,0);
          lcd.print("You Lost!");
          delay(5000);
          break;
        }
    
        lcd.clear();
          lcd.setCursor(i,pos2);
          lcd.write(3); // colocando bala
          
          lcd.setCursor(1,pos2); // colocando armas
          lcd.write(1);
      
         lcd.setCursor(15,pos2); // colocando alvo
          lcd.write(2);
        
        delay(100);
        count = count +1;
        if(count ==3){
          lcd.clear();
          lcd.setCursor(i,pos2);
          lcd.write(3); // colocando bala
          
          lcd.setCursor(1,pos2); // colocando armas
          lcd.write(1);
      
          lcd.setCursor(15,pos); // colocando alvo
          lcd.write(2);
          delay(200);
  
          
    
          count = 0;
          break;
        } // else
       }// while
     }// for
     
     if(pos2 ==1){
            pos2 = 0;
          }
          else
          {
            pos2 = 1 ;
          }
  }
}
