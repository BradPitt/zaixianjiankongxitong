// 数字前面自动补零
// num传入的数字，n需要的字符长度
function PrefixInteger(num, n) {
    return (Array(n).join(0) + num).slice(-n);

}
// 用JS获取地址栏参数的方法
function GetQueryString(name) {
    var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)", "i");
    var r = window.location.search.substr(1).match(reg);
    if (r != null) {
        return unescape(r[2]);
    } else {
        return null;
    }
}
// 计算两个经纬度之间的距离
function GetDistance(lat1, lng1, lat2, lng2) {
    if ((Math.abs(lat1) > 90) || (Math.abs(lat2) > 90)) {
        return "0";
    }
    if ((Math.abs(lng1) > 180) || (Math.abs(lng2) > 180)) {
        return "0";
    }
    var radLat1 = rad(lat1);
    var radLat2 = rad(lat2);
    var a = radLat1 - radLat2;
    var b = rad(lng1) - rad(lng2);
    var s = 2 * Math.asin(Math.sqrt(Math.pow(Math.sin(a / 2), 2) +
	Math.cos(radLat1) * Math.cos(radLat2) * Math.pow(Math.sin(b / 2), 2)));
    s = s * 6378.137;// EARTH_RADIUS;
    s = Math.round(s * 10000) / 10000;
    return s;
}