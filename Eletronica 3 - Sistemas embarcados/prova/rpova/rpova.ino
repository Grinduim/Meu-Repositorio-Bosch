#include <Firebase.h>
#include <FirebaseESP32.h>
#include <LiquidCrystal.h>
#include <DHT.h>
#include <WiFi.h>

int led1 = 5;
int led2 =15;
int led3 = 2;
int led4 = 4;
LiquidCrystal lcd(14,27,26,25,33,32);
DHT dht(12, DHT11);

#define WIFI "Vivo-InternetBF17" // rede wifi
#define WIFI_PASS "78814222" // senha do wifi

#define FIREBASE_HOST "https://prova-sistemas-embarcados-default-rtdb.firebaseio.com/" // caminho da firebase
#define TOKEN_FIREBASE "flCDeRp3QGBLNYNOeMJFpNpxm7pPjyMdL9i2NQot" //token de acesso

int button = 34;
void setup() {
  // put your setup code here, to run once:
  pinMode(button,INPUT_PULLUP);
  lcd.begin(16,2);
  lcd.clear();
  dht.begin();
  pinMode(led1,OUTPUT);
  pinMode(led2,OUTPUT);
  pinMode(led3,OUTPUT);
  pinMode(led4,OUTPUT);


   WiFi.begin(WIFI, WIFI_PASS);
  while (WiFi.status() != WL_CONNECTED) {
    Serial.print(".");
    delay(300);
  }
  Serial.print("Connected with ip: ");
  Serial.println(WiFi.localIP());

  Firebase.begin(FIREBASE_HOST,TOKEN_FIREBASE);
  Firebase.reconnectWiFi(true);
  Firebase.setReadTimeout(firebaseData,100*60);
  Firebase.setwriteSizeLimit(firebaseData, "tiny");
}

void loop() {
  // put your main code here, to run repeatedly:
  lcd.clear();
 

  if(digitalRead(button)){
     int temp = dht.readTemperature();
    if(temp <=25){
      apagarled();
      digitalWrite(led1,HIGH);
    }
    else if(temp<=27){
      apagarled();
      digitalWrite(led2,HIGH);
    }
    else{
      apagarled();
      digitalWrite(led3,HIGH);
    }
    digitalWrite(led4,HIGH);
    
    lcd.setCursor(0,0);
    lcd.print("Temp:");
    lcd.print(temp);
    lcd.print("C");
    float humi = dht.readHumidity();
    lcd.setCursor(0,1);
    lcd.print("Humi:");
    lcd.print(humi);
    EnviarDados(temp,humi);
    
    delay(1500);
  }
  else{
    apagarled();
    delay(2000);
  }
}

void apagarled(){
  digitalWrite(led1,LOW);
  digitalWrite(led2,LOW);
  digitalWrite(led3,LOW);
  digitalWrite(led4,LOW);
}
void EnviarDados(int temp, float humi){
  json.set("/Temperatura",temp);
  json.set("/Humidade",humi);
  Firebase.updateNode(firebaseData,"/Sensor",json);
}
