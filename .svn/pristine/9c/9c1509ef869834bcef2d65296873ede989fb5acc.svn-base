var viewMap;
var navToolbar;
var initialExtent;
var BUOY_DATA;
var STATION_DATA;

$(function () {

    $.ajax({
        type: "POST",
        dataType: "JSON",
        url: "/Api/Map/GetMapEquipment",
        success: function (result) {
            var data = JSON.parse(result);
            if (data[0] == null || data[1] == null) {
                alert("设备数据加载失败！")
            } else {
                BUOY_DATA = data[1];
                STATION_DATA = data[0];
            }            
            initMap("MapDiv");
        }
    });

});


function initMap(container_string) {
    require([
        "esri/map",
        "esri/geometry/Extent",
        "esri/SpatialReference",
        "esri/layers/GraphicsLayer"
    ], function (Map, Extent, SpatialReference, GraphicsLayer) {

        initialExtent = new Extent(117, 35.327, 123, 40.895,
                        new SpatialReference({ wkid: 4326 }));

        var map = new Map(container_string, {
            extent: initialExtent,
            logo: false
        });
        viewMap = map;

        buoyLayer = new GraphicsLayer({ "id": "buoyLayer" });
        map.addLayer(buoyLayer, 1);
        buoyTextLayer = new GraphicsLayer({ "id": "buoyTextLayer" });
        map.addLayer(buoyTextLayer, 1);
        dojo.connect(buoyLayer, "onClick", doBuoyIdentify);

        stationLayer = new GraphicsLayer({ "id": "stationLayer" });
        map.addLayer(stationLayer, 1);
        stationTextLayer = new GraphicsLayer({ "id": "stationTextLayer" });
        map.addLayer(stationTextLayer, 1);
        dojo.connect(stationLayer, "onClick", doStationIdentify);

        AddDynamicLayer("ditu", "http://services.arcgisonline.com/ArcGIS/rest/services/World_Imagery/MapServer");
        dojo.connect(viewMap, "onLoad", LoadMapComponents);
        addDevice(BUOY_DATA, "../img/buoy.png", buoyLayer, buoyTextLayer);
        addDevice(STATION_DATA, "../img/station.png", stationLayer, stationTextLayer);

    });      
    
    
}

//添加浮标 
function addDevice(data, path, layer, textLayer) {
    require([
        "esri/geometry/Point",
        "esri/graphic",
        "esri/symbols/PictureMarkerSymbol",
        "esri/symbols/TextSymbol",
        "esri/Color",
        "esri/symbols/Font"
    ], function (Point, Graphic, PictureMarkerSymbol, TextSymbol, Color, Font) {
        for (var i = 0; i < data.length; i++) {
            var pt = new Point(data[i].ELON, data[i].ELAT, viewMap.spatialReference);

            var graphic = new Graphic(pt, new PictureMarkerSymbol(path, 34, 34), data[i]);

            var textSymbol = new TextSymbol(data[i].DEVICENAME);
            textSymbol.setColor(new Color([0, 0, 0]));
            var font = new Font();
            font.setSize("10pt");
            font.setWeight(Font.WEIGHT_BOLD);
            textSymbol.setFont(font);
            textSymbol.setHaloSize(1);
            textSymbol.setHaloColor(new Color([255, 255, 255]));
            textSymbol.setOffset(0, -35);
            var text = new Graphic(pt, textSymbol, data[i]);

            layer.add(graphic);
            textLayer.add(text);
        }
    });
}

function LoadMapComponents() {
    require(["esri/toolbars/navigation"], function (Navigation) {
        navToolbar = new Navigation(viewMap);
        dojo.connect(navToolbar, "onExtentHistoryChange", extentHistoryChangeHandler);
    });    
}

function extentHistoryChangeHandler() {
    if (!navToolbar.isFirstExtent()) {
        dojo.byId("zoomprev").disabled = false;
        dojo.byId("zoomprev").src = "../img/icon-left.png";
    }
    else {
        dojo.byId("zoomprev").disabled = true;
        dojo.byId("zoomprev").src = "../img/d-icon-left.png";
    }

    if (!navToolbar.isLastExtent()) {
        dojo.byId("zoomnext").disabled = false;
        dojo.byId("zoomnext").src = "../img/icon-right.png";
    }
    else {
        dojo.byId("zoomnext").disabled = true;
        dojo.byId("zoomnext").src = "../img/d-icon-right.png";
    }
}

function doBuoyIdentify(evt) {
    ResetSymbol();
    require([
        "esri/symbols/PictureMarkerSymbol"
    ], function (PictureMarkerSymbol) {
        var bigSymbol = new PictureMarkerSymbol("../img/buoy.png", 50, 50)
        evt.graphic.setSymbol(bigSymbol);
        viewMap.infoWindow.setTitle("浮标在线监测站");
        var con = "<div>编号：" + evt.graphic.attributes.DEVICECODE + "</div>";
        con = con + "<div>名称：" + evt.graphic.attributes.DEVICENAME + "</div>";
        con = con + "<div>经度：" + evt.graphic.attributes.ELON + "</div>";
        con = con + "<div>纬度：" + evt.graphic.attributes.ELAT + "</div>";
        viewMap.infoWindow.setContent(con);
        viewMap.infoWindow.show(evt.screenPoint, viewMap.getInfoWindowAnchor(evt.screenPoint));
        viewMap.infoWindow.show();
    });   
}

function doStationIdentify(evt) {
    ResetSymbol();
    require([
        "esri/symbols/PictureMarkerSymbol"
    ], function (PictureMarkerSymbol) {
        var bigSymbol = new PictureMarkerSymbol("../img/station.png", 50, 50)
        evt.graphic.setSymbol(bigSymbol);
        viewMap.infoWindow.setTitle("岸基在线监测站");
        var con = "<div>编号：" + evt.graphic.attributes.DEVICECODE + "</div>";
        con = con + "<div>名称：" + evt.graphic.attributes.DEVICENAME + "</div>";
        con = con + "<div>经度：" + evt.graphic.attributes.ELON + "</div>";
        con = con + "<div>纬度：" + evt.graphic.attributes.ELAT + "</div>";
        viewMap.infoWindow.setContent(con);
        viewMap.infoWindow.show(evt.screenPoint, viewMap.getInfoWindowAnchor(evt.screenPoint));
        viewMap.infoWindow.show();
    });    
}

function ResetSymbol()
{
    require([
        "esri/symbols/PictureMarkerSymbol"
    ], function (PictureMarkerSymbol) {
        var buoy = viewMap.getLayer("buoyLayer");
        $.each(buoy.graphics, function (i, val) {       
            var smallSymbolb = new PictureMarkerSymbol("../img/buoy.png", 34, 34);
            val.setSymbol(smallSymbolb);
        });
        var station = viewMap.getLayer("stationLayer");
        $.each(station.graphics, function (i, val) {
            var smallSymbols = new PictureMarkerSymbol("../img/station.png", 34, 34);
            val.setSymbol(smallSymbols);       
        });

    });
}

function AddDynamicLayer(id, url) {
    require([
        "esri/layers/ArcGISDynamicMapServiceLayer"
    ], function (ArcGISDynamicMapServiceLayer) {
        var layer = new ArcGISDynamicMapServiceLayer(url);
        layer.id = id;
        viewMap.addLayer(layer);
    });
}

function ZoomIn() {
    viewMap.setCursor("crosshair");
    navToolbar.activate(esri.toolbars.Navigation.ZOOM_IN);
}

function ZoomOut() {
    viewMap.setCursor("crosshair");
    navToolbar.activate(esri.toolbars.Navigation.ZOOM_OUT);
}

function Pan() {
    viewMap.setCursor("move");
    navToolbar.activate(esri.toolbars.Navigation.PAN);
}

function Full() {
    viewMap.setExtent(initialExtent);
}

function GetExtent(type)
{
    ResetSymbol();
    var RESULT_DATA;
    value = {
        DEVICECODE: $("#DEVICECODE").val(),
        SEAAREA: $("#SEAAREA option:selected").val(),
        PROVINCE: $("#PROVINCE option:selected").val(),
        BAY: $("#BAY option:selected").val(),
        BUREAUDEVICE: $("#BUREAUDEVICE option:selected").val(),
        LOCALDEVICE: $("#LOCALDEVICE option:selected").val(),
        SERVICE: $("#SERVICE option:selected").val(),
        PICTUREPATH: null
    }    
    require([
        "esri/geometry/Point",
        "esri/geometry/Multipoint",
        "esri/symbols/PictureMarkerSymbol"
    ], function (Point, Multipoint, PictureMarkerSymbol) {
        $.ajax({
            type: "POST",
            dataType: "JSON",
            url: "/Api/Map/SearchEquipment?type=" + type + "&value=" + JSON.stringify(value),
            success: function (result) {               
                if (result == "[]") {
                    alert("没有符合查询条件的设备！");
                } else {
                    var data = JSON.parse(result);
                    RESULT_DATA = data;
                    var multiPoint = new Multipoint();

                    for (i = 0; i < RESULT_DATA.length; i++) {
                        multiPoint.addPoint(new Point(RESULT_DATA[i].ELON, RESULT_DATA[i].ELAT, viewMap.spatialReference));
                        var buoy = viewMap.getLayer("buoyLayer");
                        $.each(buoy.graphics, function (n, val) {
                            if (val.attributes.DEVICECODE == RESULT_DATA[i].DEVICECODE) {
                                var bigSymbolb = new PictureMarkerSymbol("../img/buoy.png", 50, 50);
                                val.setSymbol(bigSymbolb);
                            }
                        });
                        var station = viewMap.getLayer("stationLayer");
                        $.each(station.graphics, function (n, val) {
                            if (val.attributes.DEVICECODE == RESULT_DATA[i].DEVICECODE) {
                                var bigSymbols = new PictureMarkerSymbol("../img/station.png", 50, 50);
                                val.setSymbol(bigSymbols);
                            }
                        });
                    }
                    viewMap.setExtent(multiPoint.getExtent().expand(1.5));
                }
                
            }
        });
        
    });
}
