#include <FirebaseESP32.h>
#include <Firebase.h>
#include <LiquidCrystal.h>
#include <WiFi.h> // libs

#define WIFI "Vivo-InternetBF17" // rede wifi
#define WIFI_PASS "78814222" // senha do wifi

#define FIREBASE_HOST "https://esp32-457c3-default-rtdb.firebaseio.com/" // caminho da firebase
#define TOKEN_FIREBASE "FhCR8tgGBnAFgJPtyqDsMBxPVsxieMoaaRURf6ro" //token de acesso

FirebaseData firebaseData;
FirebaseJson json;

LiquidCrystal lcd(27,26,25,33,32,14); // portas do lcd
int Led = 5; // pin led
int Ldr = A0; // pin ldr
int ValorLuz = 0; // var para receber a leitura
void setup() {
  // put your setup code here, to run once:
  lcd.begin(16,2);
  Serial.begin(9600);
  pinMode(Led,OUTPUT); // configurando o led

  WiFi.begin(WIFI, WIFI_PASS);
  while (WiFi.status() != WL_CONNECTED) {
    Serial.print(".");
    delay(300);
  }
  Serial.print("Connected with ip: ");
  Serial.println(WiFi.localIP());

  Firebase.begin(FIREBASE_HOST,TOKEN_FIREBASE):
  Firebase.reconnectWiFi(true);
  Firebase.setReadTimeout(firebaseData,100*60);
  Firebase.setwriteSizeLimit(firebaseData, "tiny");
}

void loop() {
  // put your main code here, to run repeatedly:
  digitalWrite(Led,LOW);
  ValorLuz = analogRead(Ldr);
  if(!isnan(ValorLuz)){
    ValorLuz = map(ValorLuz,0,4095,0,100);
    RetornoVal(int ValorLuz);
    digitalWrite(Led,HIGH);
    json.set("/Luminosidade",ValorLuz);// setando os valores a serem enviados por json
    Firebase.updateNode(firebaseData,"/SensorLuz",json); // atualizando a firebase
    delay(1500);
    digitalWrite(Led,LOW);
  }
  else{
    digitalWrite(Led,LOW);
    
  }
  delay(15000);
  
}

void RetornoVal(int ValorLuz){
    Serial.println(ValorLuz);
    lcd.clear();
    lcd.setCursor(0,0);
    lcd.print(ValorLuz);
    delay(1500);
}
