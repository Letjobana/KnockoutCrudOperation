function GetZones() {
    $.ajax({
        type: "Get",
        url: routeSettings.testingUrl + "/zones/getallzones",
        data: { credential: credentialsDto},
        success: function (response) {          
        },
        error: function () {          
        },
    });
}