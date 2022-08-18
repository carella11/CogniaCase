using System.Text.Json;
using CogniaCase1;

//serializes and reads the json file
var restStopsJson = File.ReadAllText("parkeringsomraade.json");
var restStops = JsonSerializer.Deserialize<RestStopModel[]>(restStopsJson);

//This is to create a local server.
var builder = WebApplication.CreateBuilder();
var app = builder.Build();
app.UseHttpsRedirection();

    app.MapGet("/FindStopsWithFacilities", () =>
    {
        List<RestStopModel> stopsWithFacilities = new List<RestStopModel>();
        foreach (var restStop in restStops)
        {
            //if reststop has no facilities, continue to the next one)
            if (restStop.facilities == null) continue;
            // if reststop has a shower and parking for trucks, then add to list the list of reststops with facilities.
            if (restStop.facilities.shower && restStop.parkingForTrucks)
            {
                stopsWithFacilities.Add(restStop);
            }
        }
        return stopsWithFacilities; // returns a list of stops with facilities
    });
app.Run();
