using System;

namespace TestApi
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }


        public WeatherForecast(int index){
            var rng = new Random();

            Date = DateTime.Now.AddDays(index);
            TemperatureC = rng.Next(-20, 55);
            Summary = GetSummary(TemperatureC);
        }

<<<<<<< HEAD
<<<<<<< HEAD
        public WeatherForecast(int days, int temp){
            Date = DateTime.Now;
            TemperatureC = SetTemperature(temp);
            Summary = GetSummary(TemperatureC);
        }

        public string GetSummary(int? temp){
            if(temp == null){
                return "No temperature recorded";
            }else if(temp >= 40){
=======
        public string GetSummary(int temp){
            if(temp >= 40){
>>>>>>> Initial creation of WeatherForecast Project
=======
        public string GetSummary(int temp){
            if(temp >= 40){
>>>>>>> c8122a3de0db456a9348f015441d2caa55f6ae7a
                return "Sweltering";
            }else if(temp < 40 && temp >= 30){
                return "Hot";
            }else if(temp < 30 && temp >= 20){
                return "Warm";
            }else if(temp < 20 && temp >= 10){
                return "Mild";
            }else if(temp < 10 && temp >= 0){
                return "Chilly";
            }else if(temp < 0 && temp >= -10){
                return "Cold";
            }else if(temp < -10 && temp >= -20){
                return "Freezing";
            }else return "Record temperature!";
        }
<<<<<<< HEAD
<<<<<<< HEAD

        private int SetTemperature(int temp){
            return temp;
        }
=======
>>>>>>> Initial creation of WeatherForecast Project
=======
>>>>>>> c8122a3de0db456a9348f015441d2caa55f6ae7a
    }
}
