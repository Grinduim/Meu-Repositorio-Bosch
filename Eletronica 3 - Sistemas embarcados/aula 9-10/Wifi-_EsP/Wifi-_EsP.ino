 #include <WiFi.h>

#define WIFI_PASS "78814222"
#define WIFI_SSID "Vivo-Internet-BF17"

void setup() {
  // put your setup code here, to run once:
  WiFi.begin(WIFI_SSID,WIFI_PASS);
  Serial.begin(9600);
  while(WiFi.status() != WL_CONNECTED){
    Serial.print(".");
    delay(300);
  }
  
  Serial.print("Connected with IP: ");
  Serial.println(WiFi.localIP());
}

void loop() {
  // put your main code here, to run repeatedly:

  
} 
