var routeSettings = {
    database: "geotab57",
    server: "my226.geotab.com",
    sessionId: "RfsARmdyLtPEUkY-Ys6I_g",
    userName: "gms@geotab.co.za",
    groupFilter: "",
    testingUrl: "https://localhost:44362/api",

};

var credentialsDto = {
    database: "",
    sessionId: "",
    userName: "",
    server: "",
};

$(document).ready(function () {
    (credentialsDto.database = routeSettings.database);
    (credentialsDto.server = routeSettings.server);
    (credentialsDto.sessionId = routeSettings.sessionId);
    (credentialsDto.server = routeSettings.server);
    GetZones();
});