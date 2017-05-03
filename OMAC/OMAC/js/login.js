
// 绑定用户名下拉框方法
function BindUserName() {
    var code = $("#department option:selected").val();

    if (code != null && code != "") {
        $.ajax({
            type: "POST",
            dataType: "json",
            url: "/Api/System/GetNameList?code=" + code,
            success: function (result) {
                if (result.data != null) {
                    Names = result.data;
                    var html = new Array();
                    html.push("<option value=''>请选择</option>");

                    $.each(Names, function (e, v) {
                        //var selectHtml = "";
                        html.push("<option value=\"" + v.F_ACCOUNT + "\">" + v.F_NAME + "</option>");
                    });

                    $("#F_NAME").html(html.join(''));
                }
            },
            error: function (data) {

            }
        });

        //$.post("/Api/System/GetNameList", { code: code }, function (result) {
        //    if (result.data != null) {
        //        Names = result.data;
        //        var html = new Array();
        //        //html.push("<option value=''>请选择</option>");

        //        $.each(Names, function (e, v) {
        //            //var selectHtml = "";
        //            html.push("<option value=\"" + v.F_ACCOUNT + "\">" + v.F_NAME + "</option>");
        //        });

        //        $("#F_NAME").html(html.join(''));
        //    }
        //});
    }

}

// 登录方法
function Login() {
    var department = $("#department option:selected").val();
    var name = $("#F_NAME option:selected").val();
    var pwd = $("#F_PASSWORD").val();
    $("#message").text("");

    if (department == "" || department == null) {
        $("#message").text("请选择部门");
        return false;
    }

    if (name == "" || name == null) {
        $("#message").text("请选择用户名");
        return false;
    }

    if (pwd == "" || pwd == null) {
        $("#message").text("请输入密码");
        return false;
    }

    $.ajax({
        type: "POST",
        dataType: "json",
        url: "/Api/System/Logins",
        data: { F_NAME: $("#F_NAME option:selected").text(), F_PASSWORD: pwd },
        success: function (result) {
            if (result.success) {
                //window.location.href = "/Manager/Index";
                window.location = "/Manager/Logins?userID=" + result.data[0].F_ACCOUNT
            }
            else {
                bootbox.alert({ buttons: { ok: { label: '关闭', className: 'btn btn-blue ' } }, message: "<h4 style='text-align:center'>账号密码错误，请重新输入</h4>" })
            }
        },
        error: function (data) {

        }
    });

}

//$(function () {
//    // 表单验证
//    $('#userlogin').bootstrapValidator({
//        message: '请正确输入',
//        feedbackIcons: {
//            valid: 'glyphicon glyphicon-ok',
//            invalid: 'glyphicon glyphicon-remove',
//            validating: 'glyphicon glyphicon-refresh'
//        },
//        trigger: 'change',
//        fields: {
//            department: {
//                validators: {
//                    notEmpty: {
//                        message: '请选择部门'
//                    },
//                }
//            },
//            F_NAME: {
//                validators: {
//                    notEmpty: {
//                        message: '请选择用户名'
//                    },
//                }
//            },
//            F_PASSWORD: {
//                validators: {
//                    notEmpty: {
//                        message: '请输入密码'
//                    },
//                    stringLength: {
//                        min: 1,
//                        max: 20,
//                        message: '密码长度必须在1到10之间'
//                    },
//                }
//            }
//        }
//    }).on('success.form.bv', function (e) {//点击提交之后
//        //阻止表单提交
//        e.preventDefault();

//        // Get the form instance
//        var $form = $(e.target);

//        // Get the BootstrapValidator instance
//        var bv = $form.data('bootstrapValidator');

//        // Use Ajax to submit form data 提交至form标签中的action，result自定义
//        $.post($('#userlogin').attr('action'), $form.serialize(), function (result) {
//            if (result.success) {
//                bootbox.setLocale("zh_CN");
//                bootbox.alert({
//                    message: "操作成功!",
//                    callback: function () {
//                        parent.window.CloseTabByTitle();
//                    }
//                })
//            }
//            else {
//                $(".addre").removeAttr("disabled");
//                bootbox.alert(result.Message);
//            }
//        });
//    });
//});