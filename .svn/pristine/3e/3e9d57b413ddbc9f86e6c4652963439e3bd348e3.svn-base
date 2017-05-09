// 数字前面自动补零
// num传入的数字，n需要的字符长度
function PrefixInteger(num, n) {
    return (Array(n).join(0) + num).slice(-n);

}
// 用JS获取地址栏参数的方法
function GetQueryString(name) {
    var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)");
    var r = window.location.search.substr(1).match(reg);
    if (r != null) return unescape(r[2]); return null;
}