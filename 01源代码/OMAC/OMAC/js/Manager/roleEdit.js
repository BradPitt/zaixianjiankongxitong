﻿$(function () {

    $("#btn-submit").on("click", function () {
        var roleName = $("input[name=\"role-name\"]").val();
        if (roleName==="") {
            bootbox.alert("名称不能为空!");
            return;
        }
        $.post("/api/system/EditRole",
            {
                "F_ROLECODE": $("input[name=\"role-id\"]").val(),
                "F_NAME": $("input[name=\"role-name\"]").val(),
                "F_DESCRIPTION": $("textarea[name=\"role-desc\"]").val()
            },
            function(rspData) {
                if (rspData.status === true) {
                    bootbox.alert("操作成功!",
                        function() {
                            location.href = "Role";
                        });
                } else {
                    bootbox.alert("操作失败!");
                }
            });
    });

});

