
// TODO 页面尺寸初始化
/**
 * TODO 页面尺寸初始化
 * @return {[type]} [description]
 */
var init = function () {
    var waterContentDefH = $(".waterBox .content").height();
    titleH = $("body > div.title").height() + 40;
    console.log(titleH);
    if ($(window).height() < 768 && $(window).width() >= 1024) {
        $("html").css({
            "overflow-y": "scroll",
            "overflow-x": "hidden"
        });
    } else if ($(window).width() < 1024 && $(window).height() >= 768) {
        $("html").css({
            "overflow-y": "hidden",
            "overflow-x": "scroll"
        });
    } else if ($(window).width() < 1024 && $(window).height() < 768) {
        $("html").css({
            "overflow-y": "scroll",
            "overflow-x": "scroll"
        });
    } else {
        $("html").css({
            "overflow": "hidden"
        });
    }
    // 地图页面高度调整
    if (wH >= 768 + titleH) {
        $("body > div.title").css("top", ($("body > div.content").offset().top - $("body > div.title").height()) / 2);
        $(".waterBox .title").css("top", ((wH - $("body > div.content").height()) / 2 - $(".waterBox .title").height()) / 2);
        $(".waterBox .zhuangtai").css("top", (wH - $("body > div.content").height()) / 2 - $(".waterBox .title").height());
        if ((wH - $("body div.content").height()) / 2 > titleH) {
            titleH = (wH - $("body  div.content").height()) / 2;
        }
        $("body div.content").css(unti.mTranslate(0, titleH + "px"));
        $("body div.title").css("top", (titleH - $("body > div.title").height()) / 2);
        $(".waterBox .zhuangtai").css("top", titleH - $(".waterBox .zhuangtai").height() - 10);
    } else {
        $("body > div.title").css("top", 30);
        $("body  div.content").height(wH - titleH - 10);
        $("body  div.content").css(unti.mTranslate(0, titleH + "px"));
        $("body  div.content .content_left .canvas").height(wH - titleH - 10);
        $(".waterBox .zhuangtai").css("margin-top", titleH - $(".waterBox .zhuangtai").height());
        $(".waterBox > .title").css(unti.mTranslate(0, (titleH - $(".waterBox > .title").height()) / 2 + "px"));
    }

    if (wW > 1440) {
        $("div.content").css({
            "width": "80%",
            "margin-left": wW * 0.8 > 1280 ? -1280 / 2 + "px" : -(wW * 0.8) / 2 + "px"
        });
        $("div.content .content_right").css({
            "width": wW * 0.8 > 1280 ? 1280 - 824 : wW * 0.8 - 824
        })
    } else {
        $("div.content").css({
            "width": "1024px",
            "margin-left": -(1024 / 2) + "px"
        });
        $("div.content .content_right").css({
            "width": (1024 - 824) + "px"
        })
    }
    if ($(window).width() < 1024) {
        $("div.content").css({
            "left": 0,
            "margin-left": 0
        });
    }
    //videoUL 
    $(".shipin1").css({
        "position: ": "absolute",
        "right": "174px",
        "display": "none"
    });
    $(".waterBox .b.content,.waterBox .c.content,.waterBox .d.content,.waterBox .e.content,.waterBox .f.content,.waterBox .g.content").css(unti.mTranslate("150%", titleH + "px", 1, 1));
    $(".waterBox").css(unti.mTranslate("100%", 0, 0, 1));
    setTimeout(function () {
        $("body > div.title,body > div.content").css("opacity", 1);
        creatChart();
        $(".waterBox").css("opacity", 1);
        Handler_content = setInterval(function () {
            disposeChart();
            creatChart();
            console.log('update map data');
        }, refesTime)
    }, 300)
}


// TODO 加载站点详细信息界面
/**
 * TODO 加载站点详细信息界面
 * @return {[type]} [description]
 */
function atooltip(e, option, t) {
    if (option.title == "") return;
    if ($(".atooltip").length) {
        $(".atooltip").html(option.title).append($("<div>", { "class": "jiantou" }));
    } else {
        $("<div>", { "class": "atooltip" }).html(option.title).append($("<div>", { "class": "jiantou" })).appendTo('body');
    }
    if (t != undefined && t == 1) {
        $(".atooltip").addClass('showTop');
        $(".atooltip").show().css({
            left: $(e.target).closest('li').offset().left + $(e.target).closest('li').width() / 2 - $(".atooltip").width() / 2,
            top: $(e.target).offset().top - $(e.target).height() - 30
        })
    } else {
        $(".atooltip").removeClass('showTop');
        $(".atooltip").show().css({
            left: $(e.target).closest('li').offset().left + $(e.target).closest('li').width() / 2 - $(".atooltip").width() / 2,
            top: $(e.target).offset().top + $(e.target).height() + 10
        })
    }
}

function addToolTipHander(li, t) {
    $(li).on("mouseenter", function (e) {
        if ($(e.target).closest('div.center').length == 0 && ($(e.target).is("li[data-title]") || $(e.target).closest('li[data-title]').length > 0)) {
            clearTimeout(removeatooltip);
            atooltip(e, {
                title: $(this).closest('li').attr("data-title"),
                placement: 'bottom'
            }, t)
        }
    });

    $(li).on("mouseleave", function (e) {
        if ($(e.target).closest('li[data-title]').length > 0) {
            clearTimeout(removeatooltip);
            if ($(e.target).is('.atooltip')) clearTimeout(removeatooltip);
            else removeatooltip = setTimeout(function () { $(".atooltip").remove(); }, 200);
        }
    });
}
$(function (e) {
    showLoad();
    var isfirstLoadqx = true;
    var isfirstLoadB = true;
    var isfirstLoadD = true;
    setValue();
    setInterval(function () {
        setValue();
    }, refesTime);

    init();
    /**
     * 监听鼠标滚轮事件
     * @param
     * @return {[type]}    [description]
     */

    function removeOrAdd($b) {
        var $ul = $b.closest('li').find('[data-wheel="continer"]');
        $ul.children('li').addClass('off');
        $b.each(function (index, el) {
            if ($(el).hasClass('active'))
                $ul.find("li." + $(el).data("type")).removeClass('off');
            else
                $ul.find("li." + $(el).data("type")).addClass('off');
        });
    }
    removeOrAdd($("b.masbox.active"))
    $("b.masbox").on("click", function (e) {
        if ($(this).hasClass("active")) {
            $(this).removeClass("active");
        } else {
            $(this).addClass("active");
        }
        removeOrAdd($("b.masbox"));
    })
    var tT = (titleH - $(".waterBox > .title").height()) / 2 + "px";
    if (wH > 768 + titleH) {
        tT = 0;
    }
    var oldOpenContent = "";
    function moveContent(className) {
        $(".waterBox > .content.ok").css(unti.mTranslate("-150%", titleH + "px"));
        $(".waterBox > ." + className + ".content").css(unti.mTranslate(0, titleH + "px"));
        setTimeout(function () {
            $(".waterBox > .content").not("." + className + ".content").addClass('notransition');
            $(".waterBox > .content").not("." + className + ".content").css(unti.mTranslate("150%", titleH + "px"));
            setTimeout(function () {
                $(".waterBox > .content").not("." + className + ".content").removeClass('ok').removeClass('notransition');
                $(".waterBox > ." + className + ".content").addClass('ok');
            }, 100)
        }, 300)
    }
    // 标签切换事件
    $(".waterBox .zhuangtai span").on("click", function (e) {
        if (!$(this).hasClass("active")) {
            $(this).addClass('active').siblings('span').removeClass("active");
            clearInterval(Handler_acontent);
            clearInterval(Handler_bcontent);
            clearInterval(Handler_ccontent);
            clearInterval(Handler_dcontent);
            clearInterval(Handler_econtent);
            if ($(this).index() == 0) {
                $("#shipin1").hide();
                $("#shipin2").hide();
                $(".waterBox > .title").css(unti.mTranslate(0, tT)).addClass('ok');
                moveContent("a");
                initWaterBox(nowOpenStation, true);
            } else if ($(this).index() == 1) {
                initWaterBoxData(nowOpenStation, !isfirstLoadD);
                isfirstLoadD = false;
                $(".waterBox > .title").css(unti.mTranslate(0, tT)).addClass('ok');
                moveContent("d");
                //$("#shipin1").show();
                //$("#shipin2").show();

                var topVal = $(".videoUL li ").offset().top + 60;
                var rightVal = $(".d").offset().left - $(".videoUL li").width();

                $("#shipin1").css("top", topVal + "px");
                $("#shipin1").css("left", rightVal + "px");


                var topVal = $(".videoUL li +li").offset().top + 60;
                var rightVal = $(".d").offset().left - $(".videoUL li").width();

                $("#shipin2").css("top", topVal + "px");
                $("#shipin2").css("left", rightVal + "px");
            }
            else if ($(this).index() == 2) {
                $("#shipin1").hide();
                $("#shipin2").hide();
                setquxian(nowOpenStation, !isfirstLoadqx);
                isfirstLoadqx = false;
                $(".waterBox > .title").css(unti.mTranslate(0, tT)).addClass('ok');
                moveContent("e");
            } else if ($(this).index() == 3) {
                $("#shipin1").hide();
                $("#shipin2").hide();
                $(".waterBox > .title").css(unti.mTranslate(0, tT)).addClass('ok');
                moveContent("b");
                initBcontent(!isfirstLoadB);
                isfirstLoadB = false;
            } else if ($(this).index() == 4) {
               // window.open('/sanwei/SanWei.html')
                $("#shipin1").hide();
                $("#shipin2").hide();
                $(".waterBox > .title").css(unti.mTranslate(0, tT)).addClass('ok');
                moveContent("f");
                initBcontent(!isfirstLoadB);
                isfirstLoadB = false;
            } else if ($(this).index() == 5) {
                $("#shipin1").hide();
                $("#shipin2").hide();
                $(".waterBox > .title").css(unti.mTranslate(0, tT)).addClass('ok');
                moveContent("g");
                initBcontent(!isfirstLoadB);
                isfirstLoadB = false;
            }

        }
    })
    $(".waterBox > .a.content").addClass('ok');
    // 关闭按钮事件
    $(".waterBox .close").on("click", function (e) {
        clearInterval(Handler_acontent);
        clearInterval(Handler_bcontent);
        clearInterval(Handler_ccontent);
        clearInterval(Handler_dcontent);
        clearInterval(Handler_econtent);
        if ($(".waterBox > .a.content").hasClass('ok')) {
            $(".waterBox").css(unti.mTranslate("100%", 0, 0, 1));
            $(".waterBox .zhuangtai span").eq(0).addClass('active').siblings('span').removeClass("active");
            Handler_content = setInterval(function () {
                disposeChart();
                creatChart();
                console.log('update map data');
            }, refesTime)
        } else if ($(".waterBox > .b.content").hasClass('ok')) {
            $(".waterBox .zhuangtai span").eq(0).addClass('active').siblings('span').removeClass("active");
            $(".waterBox > .title").css(unti.mTranslate(0, tT)).addClass('ok');
            moveContent("a");
            initWaterBox(nowOpenStation, true);
        } else if ($(".waterBox > .c.content").hasClass('ok')) {
            initBcontent(true);
            $(".waterBox .zhuangtai span").eq(3).addClass('active').siblings('span').removeClass("active");
            $(".waterBox > .title").css(unti.mTranslate(0, tT)).addClass('ok');
            moveContent("b");
        } else if ($(".waterBox > .g.content").hasClass('ok')) {////
            //initBcontent(true);
            $(".waterBox .zhuangtai span").eq(0).addClass('active').siblings('span').removeClass("active");
            $(".waterBox > .title").css(unti.mTranslate(0, tT)).addClass('ok');
            moveContent("a");
        } else if ($(".waterBox > .f.content").hasClass('ok')) {////
            //initBcontent(true);
            $(".waterBox .zhuangtai span").eq(0).addClass('active').siblings('span').removeClass("active");
            $(".waterBox > .title").css(unti.mTranslate(0, tT)).addClass('ok');
            moveContent("a");
        } else if ($(".waterBox > .d.content").hasClass('ok') || $(".waterBox > .e.content").hasClass('ok')) {
            $(".waterBox .zhuangtai span").eq(0).addClass('active').siblings('span').removeClass("active");
            $(".waterBox > .title").css(unti.mTranslate(0, tT)).addClass('ok');
            moveContent("a");
            initWaterBox(nowOpenStation, true);
        }
    })
    $(".waterBox .content_right div.showmore").on("click", function (e) {
        clearInterval(Handler_bcontent);
        moveContent("c");
        $("[name=monitorid]").val(siteOption.station[nowOpenStation].id);
        $(".content_left .contentLIlist ul li").not(".titles").remove();
        timeSerch();
        $("[name=ajaxButton]").trigger('click');
        $(moreDetailInfo).html("");
    })


    $(document).on("click", function (e) {
        if ($(e.target).closest('.contentLIlist').length > 0) {
            if ($(e.target).closest("li").hasClass('pageLi')) return;
            if ($(e.target).closest("li").index() != 0) {
                var $li = $(e.target).closest("li");
                $li.addClass('active').siblings('li').not('li:first-child').removeClass('active');
                $(moreDetailInfo).html("").append('<li class="' + (function () {
                    if ($li.find('input[type=hidden]').val() == "I") return "thao";
                    else if ($li.find('input[type=hidden]').val() == "W") return "gjing";
                    else if ($li.find('input[type=hidden]').val() == "E") return "gzhang";
                    else return "thao";
                }()) + '"><span><icon></icon><span>操作内容：' + $li.find('div.b').find('span').text() + '<br/>操作时间：' + $li.find('div.c').find('span').text() + '</span></span></li>');
            }
        }
    })

    var horwheel = require('horwheel');
    var bind = (window.addEventListener !== undefined) ? 'addEventListener' : 'attachEvent',
    wheel = (window.onwheel !== undefined) ? 'wheel' :
                (window.onmousewheel !== undefined) ? 'mousewheel' :
                    (window.attachEvent) ? 'onmousewheel' : 'DOMMouseScroll';
    (window.attachEvent) ? 'onmousewheel' : 'DOMMouseScroll';
    $(".waterBox .tagBox div.tagTag").on("mouseenter", function (e) {
        horwheel(this);
    })
    $(".waterBox .tagBox div.tagTag").on("mouseleave", function (e) {
        horwheel(this, true);
    })
    function timeSerch() {
        $('.timeSerch').find('input').each(function (index, el) {
            if (index == 0) $(el).val(new Date().Format("yyyy"));
            if (index == 1) $(el).val(new Date().Format("MM"));
            $(el).datetimepicker({
                minView: index ? 3 : 4,
                maxView: index ? 3 : 4,
                startView: index ? 3 : 4,
                autoclose: true,
                todayBtn: index ? false : true,
                todayHighlight: true,
                language: 'zh-CN',
                initialDate: new Date(),
                endDate: new Date(),
                format: index ? 'mm' : 'yyyy'
            }).on('show', function (e) {
                $(".datetimepicker thead tr:first-child th.prev i").addClass('glyphicon-arrow-left');
                $(".datetimepicker thead tr:first-child th.next i").addClass('glyphicon-arrow-right');
                if (index) {
                    $(el).datetimepicker("setStartDate", $('.timeSerch').find('input').eq(0).val() + "-01-01");
                    $(el).datetimepicker("initialDate", $('.timeSerch').find('input').eq(0).val() + "-" + $('.timeSerch').find('input').eq(1).val() + "-01");
                }
            });
        });
    }
    timeSerch();
    var isFullScreen = false;
    var tVdi0W = 0, tVdi0H = 0;
    var resizeHandler, resizeHandler2;
    var wWw, hHh, isFull;
    var $nowVideo;
    $(document).on('click', function (event) {
        if ($(event.target).is("button.vjs-fullscreen-control")) {
            $nowVideo = $(event.target).closest('div.vedio').find('video');
            clearTimeout(resizeHandler);
            clearInterval(resizeHandler2);
            if (tVdi0W == 0) tVdi0W = $nowVideo.closest('div.vedio').children('div').width();
            if (tVdi0H == 0) tVdi0H = $nowVideo.closest('div.vedio').children('div').height();
            $nowVideo.css({
                width: $(window).width(),
                height: $(window).height()
            });
            getWW($(event.target));
        }
    });

    function getWW(ev) {
        resizeHandler2 = setInterval(function () {
            isFull = (document.webkitIsFullScreen || document.mozFullScreen);
            console.log(isFull);
            if (isFull == undefined || !isFull) {
                console.log(tVdi0W);
                $nowVideo.css({
                    width: tVdi0W,
                    height: tVdi0H
                });
                tVdi0W = 0;
                tVdi0H = 0;
                clearInterval(resizeHandler2);
            }
        }, 100)
    }
    var _funResize = function () {
        clearTimeout(resizeHandler);
        resizeHandler = setTimeout(function () {
            window.location.href = window.location.href;
        }, 1000)
    }

    if (!isChrome) {
        setInterval(function () {
            var $dataWheel = $("[data-wheel='wheel']");
            $dataWheel.push($(".tagBox div.tagTag"));
            $dataWheel.push($(".yibiaopan"));
            $dataWheel.push($(moreDetailInfo));
            $dataWheel.push($(logList));
            $dataWheel.each(function (index, el) {
                if (!$(el).hasClass('ps-container')) {
                    if ($(el).hasClass('tagTag')) {
                        $(el).children('ul').css({
                            width: (function () {
                                var ulw = 0;
                                $(el).find('li').each(function (indexs, els) {
                                    console.log($(els).width());
                                    ulw += parseInt($(els).width()) + 5;
                                });
                                return ulw;
                            }())
                        })
                    }
                    $(el).css({
                        "overflow": "hidden",
                        "position": "relative"
                    });
                    $(el).perfectScrollbar();
                }
            });
        }, 500)
    }
})
