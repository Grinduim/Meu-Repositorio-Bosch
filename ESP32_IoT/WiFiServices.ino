char* SSID = "Redmi Note 8";
char* PASSWORD = "12345678"; 

void initWiFi() 
{
    delay(10);
    Serial.println("------Conexao WI-FI------");
    Serial.print("Conectando-se na rede: ");
    Serial.println
    Serial.println("Aguarde");
     
    reconectWiFi();
}
  
void reconectWiFi() 
{
    if (WiFi.status() == WL_CONNECTED)
        return;
         
    WiFi.begin(SSID,PASSWORD);
     
    while (WiFi.status() != WL_CONNECTED) 
    {
        delay(100);
        Serial.print(".");
    }
   
    Serial.println();
    Serial.print("Conectado com sucesso na rede ");
    Serial.print(SSID);
    Serial.println("IP obtido: ");
    Serial.println(WiFi.localIP());
}
