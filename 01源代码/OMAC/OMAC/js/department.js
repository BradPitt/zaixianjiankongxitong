

$(function() {

    $.getJSON("/api/system/GetDepartmentTree",
        function(rspData) {
            $("#treeview1").treeview({
                levels: 2,
                data: rspData,
                onNodeSelected: function() {
                    selectedNodeChanged();
                },
                onNodeUnselected: function() {
                    selectedNodeChanged();
                }

            });

            $("#input-search").on("keyup", function() {
                var sh = $(this);
                $("#treeview1").treeview("search", [
                    sh.val(), {
                        ignoreCase: true,
                        exactMatch: false,
                        revealResults: true
                    }
                ]);
            });

            $("#btn-add").on("click", function () {
                var selectedNodes = $("#treeview1").treeview("getSelected");
                bootbox.prompt({
                    title: "请输入名称:",
                    callback: function(inputStr) {
                        $.getJSON("/api/system/AddDepartment",
                            {
                                "deptName": inputStr,
                                "pid": selectedNodes[0].id
                            },
                            function(rspData1) {
                                if (rspData1.status === true) {
                                    location.reload();
                                } else {
                                    bootbox.alert("操作失败!");
                                }
                            });
                    }
                });
            });

            $("#btn-edit").on("click", function() {
                var selectedNodes = $("#treeview1").treeview("getSelected");
                bootbox.prompt({
                    title: "请输入名称:",
                    value: selectedNodes[0].text,
                    callback: function(inputStr) {
                        $.getJSON("/api/system/UpdateDepartment",
                            {
                                "id": selectedNodes[0].id,
                                "deptName": inputStr
                            },
                            function(rspData1) {
                                if (rspData1.status === true) {
                                    location.reload();
                                } else {
                                    bootbox.alert("操作失败!");
                                }
                            });
                    }
                });
            });

            $("#btn-delete").on("click", function() {
                var selectedNodes = $("#treeview1").treeview("getSelected");
                bootbox.confirm(
                    "确定要删除当前节点吗?",
                    function(isOk) {
                        if (isOk) {
                            $.getJSON("/api/system/DeleteDepartment",
                                {
                                    "id": selectedNodes[0].id
                                },
                                function(rspData1) {
                                    if (rspData1.status === true) {
                                        location.reload();
                                    } else {
                                        bootbox.alert("操作失败!");
                                    }
                                });
                        }
                    });
            });

        });


});

function selectedNodeChanged() {
    var data = $("#treeview1").treeview("getSelected");
    if (data.length > 0) {
        var d0 = data[0];
        $("#input-search").val(d0.text);
        $("#btn-delete").prop("disabled", d0.nodes != null);
        $("#btn-add").prop("disabled", false);
        $("#btn-edit").prop("disabled", false);
    } else {
        $("#input-search").val("");
        $("#btn-add").prop("disabled", true);
        $("#btn-edit").prop("disabled", true);
        $("#btn-delete").prop("disabled", true);
    }



}