from kafka import KafkaConsumer
import json as json
import pandas as pd
import matplotlib.pyplot as plt
import numpy as np
from datetime import datetime
consumer = KafkaConsumer('testCt-ETS', group_id='Vinicius', bootstrap_servers='ct-br.exaas.bosch.com:9092',
						 value_deserializer=lambda m: json.loads(m.decode('ascii')),
						 auto_offset_reset='earliest', enable_auto_commit=False
						 )
dictio = {}
temp = []
time = []
humidity = []
air_pressure = []
i = 0
for msg in consumer:
	print(msg)
#	air_pressure.append(msg.value['air_pressure'])
#	humidity.append(msg.value['humidity'])
#	temp.append(msg.value['temp'])
#	time.append(datetime.fromtimestamp(msg.value['time']))
	i+=1
	if i > 10:
		break
'''
dictio["Time"] = time
dictio["Temp"] = temp
dictio["Humidity"] = humidity
dictio["Air_Pressure"] = air_pressure
dt = pd.DataFrame.from_dict(dictio)
print(dt)
xpoints = np.array(time)
ypoints = np.array(temp)
plt.plot(xpoints, ypoints, marker = 'o')
plt.xlabel("Time")
plt.ylabel("Temperature")
plt.title("Temp x Time")
plt.show()
xpoints2 = np.array(time)
ypoints2 = np.array(humidity)
plt.plot(xpoints2, ypoints2, marker = 'o')
plt.xlabel("Time")
plt.ylabel("Humidity")
plt.title("Humidity x Time")
plt.show()
xpoints3 = np.array(time)
ypoints3 = np.array(air_pressure)
plt.plot(xpoints3, ypoints3, marker = 'o')
plt.xlabel("Time")
plt.ylabel("Air Pressure")
plt.title("Air Pressure x Time")
plt.show()'''