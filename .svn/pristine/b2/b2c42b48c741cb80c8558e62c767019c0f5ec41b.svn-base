dojo.require("esri.map");
dojo.require("esri.dijit.BasemapToggle");
dojo.require("esri.dijit.OverviewMap");
dojo.require("esri.dijit.Scalebar");
dojo.require("esri.dijit.Legend");
dojo.require("esri.dijit.InfoWindow");
dojo.require("esri.layers.FeatureLayer");
dojo.require("esri.layers.GraphicsLayer");
dojo.require("esri.geometry");
dojo.require("esri.geometry.Point");
dojo.require("esri.geometry.Multipoint");
dojo.require("esri.geometry.Extent");
dojo.require("esri.graphic");
dojo.require("esri.InfoTemplate");
dojo.require("esri.SpatialReference");
dojo.require("esri.toolbars.draw");
dojo.require("esri.toolbars.edit");
dojo.require("esri.toolbars.navigation");
dojo.require("esri.tasks.query");
dojo.require("esri.tasks.QueryTask");
dojo.require("esri.tasks.StatisticDefinition"); 
dojo.require("esri.tasks.IdentifyTask");
dojo.require("esri.tasks.IdentifyParameters");
dojo.require("esri.graphic");
dojo.require("esri.symbols.SimpleMarkerSymbol");
dojo.require("esri.symbols.SimpleLineSymbol");
dojo.require("esri.symbols.SimpleFillSymbol");
dojo.require("esri.symbols.PictureMarkerSymbol");
dojo.require("esri.Color");
dojo.require("dojo.parser");
dojo.require("dojo._base.event");
dojo.require("dojo.domReady!")

var viewMap;
var navToolbar;
var initialExtent;
var legend;
var legend_start = false;
var identifyTask;
var identifyParams;
var myLayerService;
var cultureLayer;
var layerInfos;
var dynamicLayerInfos;
//var menu;
var actLayer = "areas";

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
    dojo.parser.parse();
    dojo.ready(function () {

        initialExtent = new esri.geometry.Extent(117, 35.327, 123, 40.895,
                        new esri.SpatialReference({ wkid: 4326 }));

        var map = new esri.Map(container_string, {
            extent: initialExtent,
            logo: false
        });
        viewMap = map;

        buoyLayer = new esri.layers.GraphicsLayer({ "id": "buoyLayer" });
        map.addLayer(buoyLayer, 1);
        dojo.connect(buoyLayer, "onClick", doBuoyIdentify);

        stationLayer = new esri.layers.GraphicsLayer({ "id": "stationLayer" });
        map.addLayer(stationLayer, 1);
        dojo.connect(stationLayer, "onClick", doStationIdentify);

        myLayerService = AddDynamicLayer("ditu", "http://services.arcgisonline.com/ArcGIS/rest/services/World_Imagery/MapServer");
        dojo.connect(myLayerService, "onLoad", LoadLayerComponents);
        addDevice(BUOY_DATA, "../img/buoy.png", buoyLayer);
        addDevice(STATION_DATA, "../img/station.png", stationLayer);

        viewMap.infoWindow.hide(function (e) {

        });
    });      
    
    
}

//添加浮标 
function addDevice(data,path,layer) {
    var items = data.items;
    for (var i = 0; i < items.length; i++) {
        var pt = new esri.geometry.Point(items[i].X, items[i].Y, viewMap.spatialReference);
        var graphic = new esri.Graphic(pt, createSymbol(path), items[i]);
        layer.add(graphic);
    }
}

function createSymbol(path) {
    var markerSymbol = new esri.symbol.PictureMarkerSymbol(path,34,34);
    return markerSymbol;
};

function LoadMapComponents() {
    showScaleBar();
    showCoordinates();
    navToolbar = new esri.toolbars.Navigation(viewMap);
    dojo.connect(navToolbar, "onExtentHistoryChange", extentHistoryChangeHandler);
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

function LoadLayerComponents() {
    LoadMapComponents();
    layerInfos = layer.layerInfos;
    dynamicLayerInfos = myLayerService.createDynamicLayerInfosFromLayerInfos();
}

function doBuoyIdentify(evt) {
    var bigSymbol = new esri.symbol.PictureMarkerSymbol("../img/buoy.png", 40, 40)
    evt.graphic.setSymbol(bigSymbol);
    viewMap.infoWindow.setTitle("浮标在线监测站");
    var con = "<div>编号：" + evt.graphic.attributes.name + "</div>";
    con = con + "<div>名称：" + evt.graphic.attributes.id + "</div>";
    con = con + "<div>经度：" + evt.graphic.attributes.X + "</div>";
    con = con + "<div>纬度：" + evt.graphic.attributes.Y + "</div>";
    viewMap.infoWindow.setContent(con);
    viewMap.infoWindow.show(evt.screenPoint, viewMap.getInfoWindowAnchor(evt.screenPoint));
    viewMap.infoWindow.show();
}

function doStationIdentify(evt) {
    var bigSymbol = new esri.symbol.PictureMarkerSymbol("../img/station.png", 40, 40)
    evt.graphic.setSymbol(bigSymbol);
    viewMap.infoWindow.setTitle("岸基在线监测站");
    var con = "<div>编号：" + evt.graphic.attributes.name + "</div>";
    con = con + "<div>名称：" + evt.graphic.attributes.id + "</div>";
    con = con + "<div>经度：" + evt.graphic.attributes.X + "</div>";
    con = con + "<div>纬度：" + evt.graphic.attributes.Y + "</div>";
    viewMap.infoWindow.setContent(con);
    viewMap.infoWindow.show(evt.screenPoint, viewMap.getInfoWindowAnchor(evt.screenPoint));
    viewMap.infoWindow.show();
}

function CreateGraphic(feature) {
    var type = feature.geometry.type;
    var geometry = feature.geometry;
    var symbol;
    switch (type) {
        case "point":
            symbol = new esri.symbol.SimpleMarkerSymbol(esri.symbol.SimpleMarkerSymbol.STYLE_CIRCLE, 13, new esri.symbol.SimpleLineSymbol(esri.symbol.SimpleLineSymbol.STYLE_SOLID, new esri.Color([0, 255, 255, 0.5]), 10), new esri.Color([0, 255, 255, 0.9])); //.setColor(new esri.Color([0, 255, 255]));
            break;
        case "polygon":
            symbol = new esri.symbol.SimpleFillSymbol(esri.symbol.SimpleFillSymbol.STYLE_SOLID, new esri.symbol.SimpleLineSymbol(esri.symbol.SimpleLineSymbol.STYLE_SOLID, new esri.Color([0, 255, 255, 0.9]), 4), new esri.Color([0, 255, 255, 0.5])); //.setColor(new esri.Color([0, 255, 255]));            
    }

    var graphic = new esri.Graphic(geometry, symbol);
    return graphic;
}

function AddDynamicLayer(id, url) {
    var layer = new esri.layers.ArcGISDynamicMapServiceLayer(url);
    layer.id = id;
    viewMap.addLayer(layer);
    return layer;
}

function ShowLegend() {
    if (!legend_start) {
        var layerManagerDiv = document.createElement("div");
        layerManagerDiv.innerHTML = '<div id="tldiv" style="z-index:24;float: right; width: auto; height: auto; margin-top: 0px; background-color: transparent;position: absolute;right:0;top:100px;">'
                                + '<div style="z-index:24;color:White;background-color: #1874BA;height: 25px; line-height:25px; vertical-align:middle; width: auto; text-align:center; margin-left: 1px">图例</div>'
                                + '<div id="legenddiv" style="position:relative,z-index:24;width: 150px; height: 260px; overflow:auto; background-color:#ffffff;opacity:1;margin-left:1px" ></div>'
                             + '</div>'
        document.getElementById("MapDiv_root").appendChild(layerManagerDiv);
        var legendLayers = [];
        legendLayers.push({ layer: myLayerService, title: "保护区", hideLayers:[5] }, { layer: cultureLayer, title: "养殖区" });
        legend = new esri.dijit.Legend({
            map: viewMap,
            layerInfos: legendLayers
        }, "legenddiv");
        legend.startup();
        legend_start = true;
    } else {
        var layerManagerDiv = document.getElementById("tldiv")
        layerManagerDiv.parentNode.removeChild(layerManagerDiv);
        legend.destroy();
        legend_start = false;
    }
    

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

function CreateContent(result) {
    var layername = result.layerName;
    var feature = result.feature;
    var conHTML = "";
    switch (layername) {
        case "视频监控":
            conHTML = "<iframe height='400px' width='630px' scrolling='no' src='http://10.0.4.26/modules/thirdParty/playwin.jsp?cameraIndexCode=130629052530498460'></iframe>";
            viewMap.infoWindow.resize(420, 400);
            break;
        case "监测数据":
            conHTML = "<div id='StationDiv'>"
                + "<table id='StationTable' class='dataTable' border='1px' width='400px'>"
                    + "<tr>"
                        + "<td style='background-color:#e3eff2'>"
                           + "<span>监测站位</span>"
                       + "</td>"
                       + "<td colspan='5'>"
                           + "<span>" + feature.attributes.STATION + "</span>"
                       + "</td>"
                   + "</tr>"
                   + "<tr>"
                       + "<td style='background-color:#e3eff2'>"
                           + "<span>监测海域</span>"
                       + "</td>"
                       + "<td colspan='5'>"
                           + "<span>" + feature.attributes.SEA + "</span>"
                       + "</td>"
                   + "</tr>"
                   + "<tr>"
                       + "<td style='background-color:#e3eff2'>"
                           + "<span>实测经度</span>"
                       + "</td>"
                       + "<td>"
                           + "<span>" + feature.attributes.X.substring(0,6) + "</span>"
                       + "</td>"
                       + "<td style='background-color:#e3eff2'>"
                           + "<span>实测纬度</span>"
                       + "</td>"
                       + "<td>"
                           + "<span>" + feature.attributes.Y.substring(0,6) + "</span>"
                       + "</td>"
                       + "<td style='background-color:#e3eff2'>"
                           + "<span>监测日期</span>"
                       + "</td>"
                       + "<td>"
                           + "<span>" + feature.attributes.DATE + "</span>"
                       + "</td>"
                   + "</tr>"
                   + "<tr>"
                       + "<td style='background-color:#e3eff2'>"
                           + "<span>水深(m)</span>"
                       + "</td>"
                       + "<td>"
                           + "<span>" + feature.attributes.WATERDEEPT + "</span>"
                       + "</td>"
                       + "<td style='background-color:#e3eff2'>"
                           + "<span>采样深度(m)</span>"
                       + "</td>"
                       + "<td>"
                           + "<span>" + feature.attributes.DEEPTH + "</span>"
                       + "</td>"
                       + "<td style='background-color:#e3eff2'>"
                           + "<span>水温(℃)</span>"
                       + "</td>"
                       + "<td>"
                           + "<span>" + feature.attributes.TEMP + "</span>"
                       + "</td>"
                   + "</tr>"
                   + "<tr>"
                       + "<td style='background-color:#e3eff2'>"
                           + "<span>盐度</span>"
                       + "</td>"
                       + "<td>"
                           + "<span>" + feature.attributes.SALT.substring(0,5) + "</span>"
                       + "</td>"
                       + "<td style='background-color:#e3eff2'>"
                           + "<span>透明度</span>"
                       + "</td>"
                       + "<td>"
                           + "<span>" + feature.attributes.TRANSP.substring(0,5) + "</span>"
                       + "</td>"
                       + "<td style='background-color:#e3eff2'>"
                           + "<span>叶绿素a(µg/L)</span>"
                       + "</td>"
                       + "<td>"
                           + "<span>" + feature.attributes.CHLO.substring(0,5) + "</span>"
                       + "</td>"
                   + "</tr>"
                   + "<tr>"
                       + "<td style='background-color:#e3eff2'>"
                           + "<span>pH</span>"
                       + "</td>"
                       + "<td>"
                           + "<span>" + feature.attributes.PH.substring(0,5) + "</span>"
                       + "</td>"
                       + "<td style='background-color:#e3eff2'>"
                           + "<span>溶解氧(mg/L)</span>"
                       + "</td>"
                       + "<td>"
                           + "<span>" + feature.attributes.DO.substring(0,5) + "</span>"
                       + "</td>"
                       + "<td style='background-color:#e3eff2'>"
                           + "<span>化学需氧量(mg/L)</span>"
                       + "</td>"
                       + "<td>"
                           + "<span>" + feature.attributes.COD.substring(0,5) + "</span>"
                       + "</td>"
                   + "</tr>"
                   + "<tr>"
                       + "<td style='background-color:#e3eff2'>"
                           + "<span>活性磷酸盐(mg/L)</span>"
                       + "</td>"
                       + "<td>"
                           + "<span>" + feature.attributes.LPH.substring(0,5) + "</span>"
                       + "</td>"
                       + "<td style='background-color:#e3eff2'>"
                           + "<span>无机氮(mg/L)</span>"
                       + "</td>"
                       + "<td>"
                           + "<span>" + feature.attributes.INNITRO.substring(0,5) + "</span>"
                       + "</td>"
                       + "<td style='background-color:#e3eff2'>"
                           + "<span>石油类(mg/L)</span>"
                       + "</td>"
                       + "<td>"
                           + "<span>" + feature.attributes.OILS.substring(0,5) + "</span>"
                       + "</td>"
                   + "</tr>"
                   + "<tr>"
                       + "<td colspan='6' style='font-size:16px;font-weight:bold;padding:8px'>"
                           + "<span>表层评价结果</span>"
                       + "</td>"
                   + "</tr>"
                   + "<tr>"
                       + "<td style='background-color:#e3eff2'>"
                           + "<span>pH</span>"
                       + "</td>"
                       + "<td>"
                           + "<span>" + feature.attributes.SPH.substring(0,5) + "</span>"
                       + "</td>"
                       + "<td style='background-color:#e3eff2'>"
                           + "<span>溶解氧(mg/L)</span>"
                       + "</td>"
                       + "<td>"
                           + "<span>" + feature.attributes.SDO.substring(0,5) + "</span>"
                       + "</td>"
                       + "<td style='background-color:#e3eff2'>"
                           + "<span>化学需氧量(mg/L)</span>"
                       + "</td>"
                       + "<td>"
                           + "<span>" + feature.attributes.SCOD.substring(0,5) + "</span>"
                       + "</td>"
                   + "</tr>"
                   + "<tr>"
                       + "<td style='background-color:#e3eff2'>"
                           + "<span>磷酸盐(mg/L)</span>"
                       + "</td>"
                       + "<td>"
                           + "<span>" + feature.attributes.SLPH.substring(0,5) + "</span>"
                       + "</td>"
                       + "<td style='background-color:#e3eff2'>"
                           + "<span>无机氮(mg/L)</span>"
                       + "</td>"
                       + "<td>"
                           + "<span>" + feature.attributes.SINNITRO.substring(0,5) + "</span>"
                       + "</td>"
                       + "<td style='background-color:#e3eff2'>"
                           + "<span>石油类(mg/L)</span>"
                       + "</td>"
                       + "<td>"
                           + "<span>" + feature.attributes.SOILS.substring(0,5) + "</span>"
                       + "</td>"
                   + "</tr>"
            if (feature.attributes.BLEVEL == "B") {
                conHTML = conHTML + "<tr>"
                       + "<td colspan='6' style='font-size:16px;font-weight:bold; padding:8px'>"
                           + "<span>底层评价结果</span>"
                       + "</td>"
                   + "</tr>"
                   + "<tr>"
                       + "<td style='background-color:#e3eff2'>"
                           + "<span>pH</span>"
                       + "</td>"
                       + "<td>"
                           + "<span>" + feature.attributes.BPH.substring(0,5) + "</span>"
                       + "</td>"
                       + "<td style='background-color:#e3eff2'>"
                           + "<span>溶解氧(mg/L)</span>"
                       + "</td>"
                       + "<td>"
                           + "<span>" + feature.attributes.BDO.substring(0,5) + "</span>"
                       + "</td>"
                       + "<td style='background-color:#e3eff2'>"
                           + "<span>化学需氧量(mg/L)</span>"
                       + "</td>"
                       + "<td>"
                           + "<span>" + feature.attributes.BCOD.substring(0,5) + "</span>"
                       + "</td>"
                   + "</tr>"
                   + "<tr>"
                       + "<td style='background-color:#e3eff2'>"
                           + "<span>磷酸盐(mg/L)</span>"
                       + "</td>"
                       + "<td>"
                           + "<span>" + feature.attributes.BLPH.substring(0,5) + "</span>"
                       + "</td>"
                       + "<td style='background-color:#e3eff2'>"
                           + "<span>无机氮(mg/L)</span>"
                       + "</td>"
                       + "<td>"
                           + "<span>" + feature.attributes.BINNITRO.substring(0,5) + "</span>"
                       + "</td>"
                       + "<td style='background-color:#e3eff2'>"
                           + "<span>石油类(mg/L)</span>"
                       + "</td>"
                       + "<td>"
                           + "<span>" + feature.attributes.BOILS.substring(0,5) + "</span>"
                       + "</td>"
                   + "</tr>"
            }
            conHTML = conHTML + "</table>"
                        + "</div>"
            viewMap.infoWindow.resize(430, 300);
            break;
        case "禁止开发区":
            conHTML = "<div id='jinzhiContainer'>"
                    + "<table id='jinzhiTable' class='dataTable' border='1px' width='300px'>"
                        + "<tr>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>名称</span>"
                            + "</td>"
                            + "<td colspan='3'>"
                                + "<span>" + feature.attributes["名称"] + "</span>"
                            + "</td>"
                        + "</tr>"
                        + "<tr>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>代码</span>"
                            + "</td>"
                            + "<td>"
                                + "<span>" + feature.attributes["代码"] + "</span>"
                            + "</td>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>地区</span>"
                            + "</td>"
                            + "<td>"
                                + "<span>" + feature.attributes["地区"] + "</span>"
                            + "</td>"
                        + "</tr>"
                        + "<tr>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>面积</span>"
                            + "</td>"
                            + "<td>"
                                + "<span>" + feature.attributes.area_ha + "</span>"
                            + "</td>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>类型</span>"
                            + "</td>"
                            + "<td>"
                                + "<span>" + feature.attributes["类型"] + "</span>"
                            + "</td>"
                        + "</tr>"
                    + "</table>"
                + "</div>"
            viewMap.infoWindow.resize(330, 100);
            break;
        case "限制开发区":
            conHTML = "<div id='xianzhiContainer'>"
                    + "<table id='xianzhiTable' class='dataTable' border='1px' width='300px'>"
                        + "<tr>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>名称</span>"
                            + "</td>"
                            + "<td colspan='3'>"
                                + "<span>" + feature.attributes["名称"] + "</span>"
                            + "</td>"
                        + "</tr>"
                        + "<tr>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>代码</span>"
                            + "</td>"
                            + "<td>"
                                + "<span>" + feature.attributes["代码"] + "</span>"
                            + "</td>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>地区</span>"
                            + "</td>"
                            + "<td>"
                                + "<span>" + feature.attributes["地区"] + "</span>"
                            + "</td>"
                        + "</tr>"
                        + "<tr>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>面积</span>"
                            + "</td>"
                            + "<td>"
                                + "<span>" + feature.attributes.area_ha + "</span>"
                            + "</td>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>类型</span>"
                            + "</td>"
                            + "<td>"
                                + "<span>" + feature.attributes["类型"] + "</span>"
                            + "</td>"
                        + "</tr>"
                    + "</table>"
                + "</div>"
            viewMap.infoWindow.resize(330, 100);
            break;
        case "保护区":
            conHTML = "<div id='areaContainer'>"
                    + "<table id='areaTable' class='dataTable' border='1px' width='400px'>"
                        + "<tr>"
                            + "<td colspan='2' style='background-color:#e3eff2'>"
                                + "<span>保护区名称</span>"
                            + "</td>"
                            + "<td colspan='2'>"
                                + "<span>" + feature.attributes["保护区名称"] + "</span>"
                            + "</td>"
                        + "</tr>"
                        + "<tr>"
                            + "<td colspan='2' style='background-color:#e3eff2'>"
                                + "<span>功能区名称</span>"
                            + "</td>"
                            + "<td colspan='2'>"
                                + "<span>" + feature.attributes["功能区名称"] + "</span>"
                            + "</td>"
                        + "</tr>"
                        + "<tr>"
                            + "<td colspan='2' style='background-color:#e3eff2'>"
                                + "<span>保护对象</span>"
                            + "</td>"
                            + "<td colspan='2'>"
                                + "<span>" + feature.attributes["保护对象"] + "</span>"
                            + "</td>"
                        + "</tr>"
                        + "<tr>"
                            + "<td colspan='2' style='background-color:#e3eff2'>"
                                + "<span>地点</span>"
                            + "</td>"
                            + "<td colspan='2'>"
                                + "<span>" + feature.attributes["地点"] + "</span>"
                            + "</td>"
                        + "</tr>"
                        + "<tr>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>管理机构</span>"
                            + "</td>"
                            + "<td>"
                                + "<span>" + feature.attributes["管理机构"] + "</span>"
                            + "</td>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>联系人</span>"
                            + "</td>"
                            + "<td>"
                                + "<span>" + feature.attributes["联系人"] + "</span>"
                            + "</td>"
                        + "</tr>"
                        + "<tr>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>批准时间</span>"
                            + "</td>"
                            + "<td>"
                                + "<span>";
         if (feature.attributes["批准时间"] != "Null")
		{
			conHTML = conHTML + feature.attributes["批准时间"];
		}
  			conHTML = conHTML + "</span>"
                            + "</td>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>批准机构</span>"
                            + "</td>"
                            + "<td>"
                                + "<span>" + feature.attributes["批准机构"] + "</span>"
                            + "</td>"
                        + "</tr>"
                        + "<tr>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>批准文号</span>"
                            + "</td>"
                            + "<td colspan='3'>"
                                + "<span>" + feature.attributes["批准文号"] + "</span>"
                            + "</td>"
                        + "</tr>"
                    + "</table>"
                + "</div>";
            if (feature.attributes["保护区名称"] == "大乳山国家级海洋公园") {
                conHTML = conHTML
               + "<div id='photoContainer'>"
                    + "<img id='photo' width='400px' height='300px' src='../photos/大乳山国家级海洋公园3.jpg' alt='大乳山国家级海洋公园' />"
                    + "<input type='image' id='left' src='../images/arrow_triangle-left.png' onclick='GetLeftPhoto()' />"
                    + "<input type='image' id='right' src='../images/arrow_triangle-right.png' onclick='GetRightPhoto()' />"
                + "</div>"
                + "<br>"
                + "<a style='cursor:pointer' onclick='openloadfile()'>查看论证报告</a>";
            }

            viewMap.infoWindow.resize(430, 300);
            break;
        case "养殖用海":
            conHTML = "<div id='cultureContainer'>"
                    + "<table id='cultureTable' class='dataTable' border='1px' width='400px'>"
                        + "<tr>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>编号</span>"
                            + "</td>"
                            + "<td>"
                                + "<span>" + feature.attributes["编号"] + "</span>"
                            + "</td>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>名称</span>"
                            + "</td>"
                            + "<td>"
                                + "<span>" + feature.attributes["名称"] + "</span>"
                            + "</td>"
                        + "</tr>"
                        + "<tr>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>登记编号</span>"
                            + "</td>"
                            + "<td>"
                                + "<span>" + feature.attributes["登记编号"] + "</span>"
                            + "</td>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>海域证号</span>"
                            + "</td>"
                            + "<td>"
                                + "<span>" + feature.attributes["海域证号"] + "</span>"
                            + "</td>"
                        + "</tr>"
                        + "<tr>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>位置</span>"
                            + "</td>"
                            + "<td colspan='3'>"
                                + "<span></span>"
                            + "</td>"
                        + "</tr>"
                        + "<tr>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>行政隶属编码</span>"
                            + "</td>"
                            + "<td>"
                                + "<span>" + feature.attributes["行政隶属编码"] + "</span>"
                            + "</td>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>行政隶属名称</span>"
                            + "</td>"
                            + "<td>"
                                + "<span>" + feature.attributes["行政隶属名称"] + "</span>"
                            + "</td>"
                        + "</tr>"
                        + "<tr>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>使用权人</span>"
                            + "</td>"
                            + "<td>"
                                + "<span>" + feature.attributes["使用权人"] + "</span>"
                            + "</td>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>项目性质</span>"
                            + "</td>"
                            + "<td>"
                                + "<span>" + feature.attributes["项目性质"] + "</span>"
                            + "</td>"
                        + "</tr>"
                        + "<tr>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>用海类型</span>"
                            + "</td>"
                            + "<td>"
                                + "<span>" + feature.attributes["用海类型"] + "</span>"
                            + "</td>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>用海面积</span>"
                            + "</td>"
                            + "<td>"
                                + "<span>" + feature.attributes["用海面积"] + "</span>"
                            + "</td>"
                        + "</tr>"
                        + "<tr>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>宗海面积</span>"
                            + "</td>"
                            + "<td>"
                                + "<span>" + feature.attributes["宗海面积"] + "</span>"
                            + "</td>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>海域等别</span>"
                            + "</td>"
                            + "<td>"
                                + "<span>" + feature.attributes["海域等别"] + "</span>"
                            + "</td>"
                        + "</tr>"
                        + "<tr>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>用海方式</span>"
                            + "</td>"
                            + "<td>"
                                + "<span>" + feature.attributes["用海方式"] + "</span>"
                            + "</td>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>用海设施及构筑物</span>"
                            + "</td>"
                            + "<td>"
                                + "<span></span>"
                            + "</td>"
                        + "</tr>"
                        + "<tr>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>许可机关</span>"
                            + "</td>"
                            + "<td>"
                                + "<span>" + feature.attributes["许可机关"] + "</span>"
                            + "</td>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>许可日期</span>"
                            + "</td>"
                            + "<td>"
                                + "<span>" + feature.attributes["许可日期"] + "</span>"
                            + "</td>"
                        + "</tr>"
                        + "<tr>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>登记日期</span>"
                            + "</td>"
                            + "<td>"
                                + "<span>" + feature.attributes["登记日期"] + "</span>"
                            + "</td>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>起始日期</span>"
                            + "</td>"
                            + "<td>"
                                + "<span>" + feature.attributes["起始日期"] + "</span>"
                            + "</td>"
                        + "</tr>"
                        + "<tr>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>终止日期</span>"
                            + "</td>"
                            + "<td>"
                                + "<span>" + feature.attributes["终止日期"] + "</span>"
                            + "</td>"
                            + "<td style='background-color:#e3eff2'>"
                                + "<span>面部分标记</span>"
                            + "</td>"
                            + "<td>"
                                + "<span>" + feature.attributes["面部分标记"] + "</span>"
                            + "</td>"
                        + "</tr>"
                    + "</table>"
                + "</div>"
            viewMap.infoWindow.resize(430, 300);
            break;
        default:
            break;

    }
    return conHTML;
}

