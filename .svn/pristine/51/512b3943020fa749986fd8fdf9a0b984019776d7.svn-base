$(function () {

    // 获取角色下拉框
    $.getJSON("/api/system/GetAllRoles",
        {
            "userAccount": $("input[name=\"user-account\"]").val()
        },
        function (rspData) {
            if (rspData != null) {

                var html = [];
                $.each(rspData, function (e, v) {
                    if (v.ISUSERHAS === 1) {
                        html.push("<option selected value=\"" + v.F_ROLECODE + "\">" + v.F_NAME + "</option>");
                    } else {
                        html.push("<option value=\"" + v.F_ROLECODE + "\">" + v.F_NAME + "</option>");
                    }
                });
                $("#roles").html(html.join(""));

                rolesSelectOnChange();

                $("#roles").on("change", function () {
                    rolesSelectOnChange();
                });

            }
        });

    // 获取部门树
    $.getJSON("/api/system/GetDepartmentTreeByUser",
        {
            "userAccount": $("input[name=\"user-account\"]").val()
        },
       function (rspData) {

           $("#treeview1").treeview({
               levels: 2,
               data: rspData,
               onNodeSelected: function () {
                   selectedNodeChanged();
               },
               onNodeUnselected: function () {
                   selectedNodeChanged();
               }
           });
           selectedNodeChanged();

       });


    $("form").validator().on("submit", function (e) {
        e.preventDefault();
        var deptdata = $("#treeview1").treeview("getSelected");
        $.post("/api/system/EditUser",
            {
                "F_ACCOUNT": $("input[name=\"user-account\"]").val(),
                "F_NAME": $("input#inputName").val(),
                "F_REALNAME": $("input#F_REALNAME").val(),
                "F_PASSWORD": $("input#inputPassword").val(),
                "F_EMAIL": $("input#inputEmail").val(),
                "F_PHONE": $("input#F_PHONE").val(),
                "F_TEL": $("input#F_TEL").val(),
                "F_DESCRIPTION": $("textarea#F_DESCRIPTION").val(),
                "F_ADDRESS": $("textarea#F_ADDRESS").val(),
                "F_DEPARTMENTCODE": deptdata[0].id,
                "Roleinfos": $("#roles").val()
            },
            function (rspData) {
                if (rspData.status === true) {
                    bootbox.alert("操作成功!",
                        function () {
                            location.href = "UserList";
                        });
                } else {
                    bootbox.alert("操作失败!");
                }
            });

    });


});

function selectedNodeChanged() {
    var data = $("#treeview1").treeview("getSelected");
    if (data.length > 0) {
        var d0 = data[0];
        $("#department").val(d0.text);
    } else {
        $("#department").val("");
    }
}

function rolesSelectOnChange() {
    var str = "";
    $("#roles option:selected").each(function () {
        str += $(this).text() + ",";
    });

    $("#inputRoles").val(str.slice(0, -1));
}