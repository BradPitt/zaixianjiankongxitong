﻿//dojo.require("esri.map");
//dojo.require("esri.dijit.OverviewMap");
//dojo.require("esri.dijit.Scalebar");
//dojo.require("esri.dijit.Legend");
//dojo.require("esri.dijit.InfoWindow");
//dojo.require("esri.layers.FeatureLayer");
//dojo.require("esri.layers.GraphicsLayer");
//dojo.require("esri.geometry");
//dojo.require("esri.geometry.Point");
//dojo.require("esri.geometry.Multipoint");
//dojo.require("esri.geometry.Extent");
//dojo.require("esri.InfoTemplate");
//dojo.require("esri.SpatialReference");
//dojo.require("esri.toolbars.navigation");
//dojo.require("esri.graphic");
//dojo.require("esri.symbols.SimpleMarkerSymbol");
//dojo.require("esri.symbols.SimpleLineSymbol");
//dojo.require("esri.symbols.SimpleFillSymbol");
//dojo.require("esri.symbols.PictureMarkerSymbol");
//dojo.require("esri.symbols.TextSymbol");
//dojo.require("esri.symbols.Font");
//dojo.require("esri.Color");
//dojo.require("dojo.parser");
//dojo.require("dojo._base.event");
//dojo.require("dojo.domReady!")

var viewMap;
var navToolbar;
var initialExtent;

var BUOY_DATA = {
    "items": [{ "id": 1, "name": "乌鲁木齐", "X": 87.575829, "Y": 43.782212 },
        { "id": 2, "name": "拉萨", "X": 91.162998, "Y": 29.71042 },
        { "id": 3, "name": "西宁", "X": 101.797303, "Y": 36.593642 },
        { "id": 4, "name": "兰州", "X": 103.584297, "Y": 36.119086 },
        { "id": 5, "name": "成都", "X": 104.035508, "Y": 30.714179 },
        { "id": 6, "name": "重庆", "X": 106.519115, "Y": 29.478925 },
        { "id": 7, "name": "贵阳", "X": 106.668071, "Y": 26.457312 },
        { "id": 8, "name": "昆明", "X": 102.726775, "Y": 24.969385 },
        { "id": 9, "name": "银川", "X": 106.167225, "Y": 38.598524 },
        { "id": 10, "name": "西安", "X": 108.967128, "Y": 34.276112 },
        { "id": 11, "name": "南宁", "X": 108.233931, "Y": 22.748296 },
        { "id": 12, "name": "海口", "X": 110.346181, "Y": 19.96992 },
        { "id": 13, "name": "广州", "X": 113.226683, "Y": 23.18307 },
        { "id": 14, "name": "长沙", "X": 112.947928, "Y": 28.169916 },
        { "id": 15, "name": "南昌", "X": 115.893715, "Y": 28.652363 },
        { "id": 16, "name": "福州", "X": 119.246768, "Y": 26.070765 }
    ]
};

var STATION_DATA = {
    "items": [
        { "id": 17, "name": "台北", "X": 121.503567, "Y": 25.008274 },
        { "id": 18, "name": "杭州", "X": 120.183046, "Y": 30.330584 },
        { "id": 19, "name": "上海", "X": 121.449707, "Y": 31.253361 },
        { "id": 20, "name": "武汉", "X": 114.216597, "Y": 30.579253 },
        { "id": 21, "name": "合肥", "X": 117.262302, "Y": 31.838353 },
        { "id": 22, "name": "南京", "X": 118.805692, "Y": 32.085022 },
        { "id": 23, "name": "郑州", "X": 113.6511, "Y": 34.746308 },
        { "id": 24, "name": "济南", "X": 117.048331, "Y": 36.60841 },
        { "id": 25, "name": "石家", "X": 114.478215, "Y": 38.033276 },
        { "id": 26, "name": "太原", "X": 112.483066, "Y": 37.798404 },
        { "id": 27, "name": "呼和浩特", "X": 111.842806, "Y": 40.895751 },
        { "id": 28, "name": "天津", "X": 117.351094, "Y": 38.925719 },
        { "id": 29, "name": "沈阳", "X": 123.296299, "Y": 41.801604 },
        { "id": 30, "name": "长春", "X": 125.26142, "Y": 43.981984 },
        { "id": 31, "name": "哈尔", "X": 126.567138, "Y": 45.69381 },
        { "id": 32, "name": "北京", "X": 116.068276, "Y": 39.892225 },
        { "id": 33, "name": "香港", "X": 114.093117, "Y": 22.427852 },
        { "id": 34, "name": "澳门", "X": 113.552482, "Y": 22.184495 }
    ]
};


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
        var items = data.items;
        for (var i = 0; i < items.length; i++) {
            var pt = new Point(items[i].X, items[i].Y, viewMap.spatialReference);

            var graphic = new Graphic(pt, new PictureMarkerSymbol(path, 34, 34), items[i]);

            var textSymbol = new TextSymbol(items[i].name);
            textSymbol.setColor(new Color([0, 0, 0]));
            var font = new Font();
            font.setSize("10pt");
            font.setWeight(Font.WEIGHT_BOLD);
            textSymbol.setFont(font);
            textSymbol.setHaloSize(1);
            textSymbol.setHaloColor(new Color([255, 255, 255]));
            textSymbol.setOffset(0, -35);
            var text = new Graphic(pt, textSymbol, items[i]);

            layer.add(graphic);
            textLayer.add(text);
        }
    });
}

function LoadMapComponents() {
    showScaleBar();
    showCoordinates();
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
        var con = "<div>编号：" + evt.graphic.attributes.name + "</div>";
        con = con + "<div>名称：" + evt.graphic.attributes.id + "</div>";
        con = con + "<div>经度：" + evt.graphic.attributes.X + "</div>";
        con = con + "<div>纬度：" + evt.graphic.attributes.Y + "</div>";
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
        var con = "<div>编号：" + evt.graphic.attributes.name + "</div>";
        con = con + "<div>名称：" + evt.graphic.attributes.id + "</div>";
        con = con + "<div>经度：" + evt.graphic.attributes.X + "</div>";
        con = con + "<div>纬度：" + evt.graphic.attributes.Y + "</div>";
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

function showScaleBar() {
    var scaleDiv = document.createElement('DIV');
    scaleDiv.id = 'scaleDiv';
    scaleDiv.style.height = '25px';
    scaleDiv.style.width = '158px';
    scaleDiv.style.bottom = '8px';
    scaleDiv.style.left = '20px';
    scaleDiv.style.position = 'absolute';
    scaleDiv.style.cursor = 'pointer';
    scaleDiv.style.backgroundColor = "white";
    document.getElementById('MapDiv_root').appendChild(scaleDiv);
    var scaleDiv2 = document.createElement('DIV');
    scaleDiv2.id = 'scaleDiv2';
    scaleDiv2.style.height = '20px';
    scaleDiv2.style.width = '148px';
    scaleDiv2.style.bottom = '0px';
    scaleDiv2.style.left = '5px';
    scaleDiv2.style.position = 'absolute';
    scaleDiv2.style.cursor = 'pointer';
    scaleDiv2.style.backgroundColor = "white";
    document.getElementById('scaleDiv').appendChild(scaleDiv2);
    var scalebar = new esri.dijit.Scalebar({
        map: viewMap,
        // "dual" displays both miles and kilometers
        // "english" is the default, which displays miles
        // use "metric" for kilometers
        scalebarUnit: "metric"
    }, dojo.byId("scaleDiv2"));
}

//显示坐标
function showCoordinates() 
{
    var coorDiv = document.createElement('DIV');
    coorDiv.style.height = '20px';
    coorDiv.style.width = '200px';
    coorDiv.style.bottom = '8px';
    coorDiv.style.right = '20px';
    coorDiv.style.position = 'absolute';
    coorDiv.style.cursor = 'pointer';
    coorDiv.style.backgroundColor = "white";
    dojo.connect(viewMap, "onMouseMove", showCoords);
    dojo.connect(viewMap, "onMouseDrag", showCoords);

    function showCoords(evt) {
        evt = evt ? evt : (window.event ? window.event : null);
        var mp = evt.mapPoint;
        coorDiv.innerHTML = "<span style='font-size:14px'>&nbsp;&nbsp;&nbsp;经度：" + mp.x.toFixed(3) + "&nbsp;&nbsp;纬度：" + mp.y.toFixed(3) + "</span>";
    };
    document.getElementById("MapDiv_root").appendChild(coorDiv);


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

function GetExtent()
{
    ResetSymbol();
    require([
        "esri/geometry/Point",
        "esri/geometry/Multipoint",
        "esri/symbols/PictureMarkerSymbol"
    ], function (Point,Multipoint, PictureMarkerSymbol) {
        var RESULT_DATA = {
            "items": [
                { "id": 17, "name": "台北", "X": 121.503567, "Y": 25.008274 },
                { "id": 18, "name": "杭州", "X": 120.183046, "Y": 30.330584 },
                { "id": 19, "name": "上海", "X": 121.449707, "Y": 31.253361 },
                { "id": 22, "name": "南京", "X": 118.805692, "Y": 32.085022 }
            ]
        }
        var multiPoint = new Multipoint();

        for (i = 0; i < RESULT_DATA.items.length; i++) {
            multiPoint.addPoint(new Point(RESULT_DATA.items[i].X, RESULT_DATA.items[i].Y, viewMap.spatialReference));
            var buoy = viewMap.getLayer("buoyLayer");
            $.each(buoy.graphics, function (n, val) {
                if (val.attributes.id == RESULT_DATA.items[i].id) {
                    var bigSymbolb = new PictureMarkerSymbol("../img/buoy.png", 50, 50);
                    val.setSymbol(bigSymbolb);
                }
            });
            var station = viewMap.getLayer("stationLayer");
            $.each(station.graphics, function (n, val) {
                if (val.attributes.id == RESULT_DATA.items[i].id) {
                    var bigSymbols = new PictureMarkerSymbol("../img/station.png", 50, 50);
                    val.setSymbol(bigSymbols);
                }
            });
        }
        viewMap.setExtent(multiPoint.getExtent().expand(2));
    });
}
