namespace ASP_NET_MIDDLEWARE
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? SummarPrueba2 { get; set; }

        public string? Summar { get; set; }
        //Hemos a�adido otro campo nuevo
        public string? SummarTT { get; set; }


    }
}
