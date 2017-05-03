/**
 * [unti 工具类方法]
 * @type {Object}
 */

var unti = {
    scale: 1,
    chinaChart:null,
    //页面正在绘图中，是不能进行更新数据的，会卡死的
    isPaiduiIng: false,
    /**
     * [isEmpty description]
     * @param  {[type]}  s [description]
     * @return {Boolean}   [description]
     */
    isEmpty: function(s) {
        if (s === undefined || s === null || s === "") return true;
        else return false;
    },
    /**
     * [获取transitionEnd事件名称]
     * @param  {Object}   []
     * @return {[type]}   []
     */
    transitionEnd: (function() {
        var body = document.body || document.documentElement
        var style = body.style;
        var transEndEventNames = {
            WebkitTransition: 'transitionend webkitTransitionEnd',
            MozTransition: 'transitionend',
            OTransition: 'oTransitionEnd otransitionend',
            transition: 'transitionend'
        }
        for (var name in transEndEventNames) {
            if (typeof style[name] === "string") {
                return transEndEventNames[name]
            }
        }
    }()),
    /**
     * [formatDegree 将度转换成为度分秒]
     * @param  {[type]} value [description]
     * @return {[type]}       [description]
     */
    formatDegree: function(value) {
        value = Math.abs(value);
        var v1 = Math.floor(value); //度
        var v2 = Math.floor((value - v1) * 60); //分
        var v3 = Math.round((value - v1) * 3600 % 60); //秒
        return v1 + '°' + v2 + '\'' + v3 + '"';
    },
    formatDate: function(date, format) {
        if (!date) return;
        if (!format) format = "yyyy-MM-dd";
        switch(typeof date) {
            case "string":
                date = new Date(date);
                break;
            case "number":
                date = new Date(date);
                break;
        }
        if (!date instanceof Date) return;
        var dict = {
            "yyyy": date.getFullYear(),
            "M": date.getMonth() + 1,
            "d": date.getDate(),
            "H": date.getHours(),
            "m": date.getMinutes(),
            "s": date.getSeconds(),
            "MM": ("" + (date.getMonth() + 101)).substr(1),
            "dd": ("" + (date.getDate() + 100)).substr(1),
            "HH": ("" + (date.getHours() + 100)).substr(1),
            "mm": ("" + (date.getMinutes() + 100)).substr(1),
            "ss": ("" + (date.getSeconds() + 100)).substr(1)
        };
        return format.replace(/(yyyy|MM?|dd?|HH?|ss?|mm?)/g, function() {
            return dict[arguments[0]];
        });
    }   ,
    /**
     * [formatDegree 度分秒转换成为度]
     * @param  {[type]} value [description]
     * @return {[type]}       [description]
     */
    DegreeConvertBack: function(value) {
        var du = value.split("°")[0];
        var fen = value.split("°")[1].split("'")[0];
        var miao = value.split("°")[1].split("'")[1].split('"')[0];
        return Math.abs(du) + "." + (Math.abs(fen) / 60 + Math.abs(miao) / 3600);
    },
    /**
     * [mTranslate css3动画效果]
     * @param  {[type]} x     [左右偏移量 % or px]
     * @param  {[type]} y     [上下偏移量 % or px]
     * @param  {[type]} scale [是否缩放 true or false]
     * @param  {[type]} ab    [缩放比例 0~1]
     * @return {[type]}       [css样式对象]
     */
    mTranslate: function(x, y, ab, bb, deg) {
        var a = 1, b = 1;
        if (deg === undefined || deg === null) deg = 0;
        if (ab!= undefined) a = ab;
        if (bb!= undefined) b = bb;
        else b = a;
        var t = {};
        t = {
            "transform": "translate(" + x + "," + y + ") scale(" + a + "," + b + ") rotate(" + deg + "deg)",
            "-ms-transform": "translate(" + x + "," + y + ") scale(" + a + "," + b + ") rotate(" + deg + "deg)",
            "-webkit-transform": "translate(" + x + "," + y + ") scale(" + a + "," + b + ") rotate(" + deg + "deg)",
            "-o-transform": "translate(" + x + "," + y + ") scale(" + a + "," + b + ") rotate(" + deg + "deg)",
            "-moz-transform": "translate(" + x + "," + y + ") scale(" + a + "," + b + ") rotate(" + deg + "deg)"
        }
        return t;
    },

    /**
     * [erci 二次贝赛尔曲线上的点]
     * @param  {[type]} p1 [description]
     * @param  {[type]} cp [description]
     * @param  {[type]} p2 [description]
     * @return {[type]}    [description]
     */
    erci: function(p1, cp, p2) {
        var tt = 0.5;
        var c1x, c1y, c2x, c2y;
        var px;
        var py;

        c1x = p1[0] + (cp[0] - p1[0]) * tt;
        c1y = p1[1] + (cp[1] - p1[1]) * tt;

        c2x = cp[0] + (p2[0] - cp[0]) * tt;
        c2y = cp[1] + (p2[1] - cp[1]) * tt;

        px = c1x + (c2x - c1x) * tt;
        py = c1y + (c2y - c1y) * tt;
        return [px, py];
    },
    /**
     * [convertData 获取两个城市间的线信息]
     * @param  {[type]} data [description]
     * @return {[type]}      [description]
     */
    convertData: function(data, CoordMap) {
        var res = [];
        for (var i = 0; i < data.length; i++) {
            var dataItem = data[i];
            var fromCoord = CoordMap[dataItem[0].name];
            var toCoord = CoordMap[dataItem[1].name];
            if (fromCoord && toCoord) {
                res.push({
                    name: dataItem[1].name,
                    coords: [fromCoord, toCoord]
                });
            }
        }
        return res;
    },
    /**
     * [convertErrPoint 计算不通的点]
     * @param  {[type]} data [description]
     * @return {[type]}      [description]
     */
    convertErrPoint: function(data, ii, curveness, CoordMap) {
        var res = [];
        if (ii == 0) return res;
        for (var i = 0; i < data.length; i++) {
            var dataItem = data[i];
            var p2 = fromCoord = CoordMap[dataItem[0].name];
            var p1 = toCoord = CoordMap[dataItem[1].name];
            var cpPoint = [
                (p1[0] + p2[0]) / 2 - (p1[1] - p2[1]) * (curveness - 0.01),
                (p1[1] + p2[1]) / 2 - (p2[0] - p1[0]) * (curveness - 0.01)
            ];
            var dt = 1.0 / 99.0 * 50;
            var curve = unti.erci(fromCoord, cpPoint, toCoord);
            if (fromCoord && toCoord) {
                res.push({
                    name: dataItem[1].name,
                    value: curve.concat(95).concat(ii)
                });
            }
        }
        return res;
    },
    /**
     * [convertToPoint 获取目的地的点坐标]
     * @param  {[type]} data [description]
     * @param  {[type]} num  [description]
     * @return {[type]}      [description]
     */
    convertToPoint: function(data, num, CoordMap, center) {
        var res = data[1].map(function(dataItem) {
            if(siteOption.nowCenter == "" || siteOption.nowCenter != dataItem[1].name){
                return {
                    name: dataItem[1].name,
                    value: CoordMap[dataItem[1].name].concat([dataItem[1].value]).concat(num)
                };
            }
        });
        // if(center != 0 && (siteOption.nowCenter == "" || siteOption.nowCenter != siteOption.center) && num == 0){
        //     res = res.concat({ name: data[0], value: CoordMap[data[0]].concat(200).concat(num) ,symbol:center.point,symbolSize:center.size,symbolOffset:[0,0]});
        // }
        return res;
    },

    readHTML: function(url) {
        $.ajax({
            async: false,
            url: url,
            success: function(result) {
                return result;
            }
        });
    },

    objNotEmpty: function(object) {
        for (var prop in object) {
            return true;
        }
        return false;
    },
    /**
     * [drawArc 渐变颜色的圆弧绘制]
     * @param  {[array]} data   [圆弧的信息]
     * @param  {[boolen]} drawModConfig [是否为更新数据]
     * @return {[void]}        []
     */

    isSelf: function(e, selecter) {
        var s = false;
        if (this.isType(selecter, 'Array')) {
            s = false;
            selecter.forEach(function(item, i) {
                if ($(e.target).closest(item).length > 0) {
                    s = true;
                }
            })
            return s;
        } else {
            s = false;
            if ($(e.target).closest(selecter).length > 0) s = true;
            else s = false;
            return s;
        }
    },
    isType: function(obj, type) {
        return (type === "Null" && obj === null) ||
            (type === "Undefined" && obj === void 0) ||
            (type === "Number" && isFinite(obj)) ||
            Object.prototype.toString.call(obj).slice(8, -1) === type;
    },
    clone: function(obj) {
        // Handle the 3 simple types, and null or undefined
        if (null == obj || "object" != typeof obj) return obj;

        // Handle Date
        if (obj instanceof Date) {
            var copy = new Date();
            copy.setTime(obj.getTime());
            return copy;
        }

        // Handle Array
        if (obj instanceof Array) {
            var copy = [];
            for (var i = 0, len = obj.length; i < len; ++i) {
                copy[i] = unti.clone(obj[i]);
            }
            return copy;
        }

        // Handle Object
        if (obj instanceof Object) {
            var copy = {};
            for (var attr in obj) {
                if (obj.hasOwnProperty(attr)) copy[attr] = unti.clone(obj[attr]);
            }
            return copy;
        }

        throw new Error("Unable to copy obj! Its type isn't supported.");
    }
};
/**
 * 全局变量
 * @type {Object}
 */
Date.prototype.Format = function (fmt) { //author: meizz
    var o = {
        "M+": this.getMonth() + 1, //月份
        "d+": this.getDate(), //日
        "h+": this.getHours(), //小时
        "m+": this.getMinutes(), //分
        "s+": this.getSeconds(), //秒
        "q+": Math.floor((this.getMonth() + 3) / 3), //季度
        "S": this.getMilliseconds() //毫秒
    };
    if (/(y+)/.test(fmt)) fmt = fmt.replace(RegExp.$1, (this.getFullYear() + "").substr(4 - RegExp.$1.length));
    for (var k in o)
    if (new RegExp("(" + k + ")").test(fmt)) fmt = fmt.replace(RegExp.$1, (RegExp.$1.length == 1) ? (o[k]) : (("00" + o[k]).substr(("" + o[k]).length)));
    return fmt;
}

$("body").append($("<div>",{"class":"loading"}));
function showLoad(){
    $(".loading").fadeIn(200);
}
function hideLoad(){
    $(".loading").fadeOut(200);
}