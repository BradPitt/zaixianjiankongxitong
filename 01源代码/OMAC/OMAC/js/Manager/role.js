$(function () {
    initTable();
});

function initTable() {

    $("#table").bootstrapTable({
        striped: true,
        pagination: true,
        height: "500",
        sidePagination: "server",
        url: "/api/system/GetRoleList",
        pageSize: 10,
        pageList: "[5, 10, 20, 50, 100, 200]",
        columns: [
            {
                field: "F_NAME", title: "名称", align: "left"
            },
            {
                field: "F_DESCRIPTION", title: "备注", align: "left"
            },
            {
                field: "F_ROLECODE",
                formatter: function (value) {
                    var html = [];
                    html.push("<div class=\"btn-group\">");
                    html.push("<a class=\"btn btn-info\" href=\"RoleDetail?roleId=" + value + "\" role=\"button\">查看</a>");
                    html.push("<a class=\"btn btn-warning\" href=\"RoleEdit?roleId=" + value + "\" role=\"button\">编辑</a>");
                    html.push("<a class=\"btn btn-danger\" href=\"javascript:deleteRole('" + value + "');\" role=\"button\">删除</a>");
                    html.push("</div>");
                    return html.join("");
                },
                title: "操作",
                align: "center"
            }
        ],
        onLoadSuccess: function () {

            var tableDatas = $("#table").bootstrapTable("getData");

            var href = tableDatas.length > 0
                ? "RoleExportExcel?roleName=" + $("input[name=\"roleName\"]").val() + "&order=asc&offset=0&limit=65500"
                : "javascript:bootbox.alert(\"无可导出数据,请尝试修改数据查询条件!\");";
            $("#btn-excel").attr("href", href);

            $("#btn-query").on("click", function () {
                GetData();
            });

        }
    });

}

function GetData() {
    $("#table").bootstrapTable("refreshOptions", {
        url: "/api/system/GetRoleList?roleName=" + $("input[name=\"roleName\"]").val()
    });
}

function deleteRole(roleId) {
    bootbox.confirm("<p style=\"color:red;font-weight:bold;\">删除该角色后,<br/>1.此角色所拥有的所有功能将被删除;<br/>2.任何用户将不会再属于此角色。<br/>您确定吗?</p>",
        function(isOk) {
            if (isOk) {
                $.getJSON("/api/system/DeleteRole",
                    {
                        "id": roleId
                    },
                    function(rspData) {
                        if (rspData.status === true) {
                            GetData();
                        } else {
                            bootbox.alert("操作失败!");
                        }
                    });
            }
        });
}