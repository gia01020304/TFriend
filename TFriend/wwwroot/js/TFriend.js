function connectToHub(nameHub, callBack) {
    var connection = new signalR.HubConnectionBuilder()
        .withUrl("/" + nameHub)
        .build();
    connection.start().catch(err => console.error(err.toString()));
    connection.on("SendMessage", callBack);
}
function showRemoveImage(element) {
    var src = $(element).attr("src");
    if (src !== "data:image/jpeg;base64,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") {
        $('.remove-image').show();
    } else {
        $('.remove-image').hide();
    }
}

function hasClass(ele, cls) {
    return ele.getAttribute('class').indexOf(cls) > -1;
}
function CallBackPopUpModal(resp, tableId) {

    var table = $('table[id="' + tableId + '"].tbl-crud').DataTable();
    table.ajax.reload(null, false);
    $('#modal-add-edit-' + tableId).modal("hide");
}
function getTemplateEditDel() {
    var templateAddDelButton = {
        data: null,
        title: "Action",
        className: "table-action text-center",
        defaultContent: '<a href="javascript:void(0)" class="text-inverse pr-10 btnEdit" data-toggle="tooltip" title="Edit" data-original-title="Edit"><i class="zmdi zmdi-edit txt-warning  zmdi-hc-2x"></i></a><a href="javascript:void(0)" class="text-inverse btnDel" title="Delete" data-toggle="tooltip" data-original-title="Delete"><i class="zmdi zmdi-delete txt-danger  zmdi-hc-2x"></i></a>'
    };
    return templateAddDelButton;
}
function createToolTip(section) {
    $(section).tooltip(
        {
            items: ".input-validation-error",
            content: function () {
                return $("[data-valmsg-for='" + $(this).attr('name') + "']").text();
            },
            classes: {
                "ui-tooltip": "custom-tooltip rounded",
                "ui-tooltip-content": "text-danger"
            },
            position: { my: "center top+15", at: "center", collision: "flipfit" }
        });
}
function showSpinner() {
    $('#spinner').show();
}
function hideSpinner() {
    $('#spinner').hide();
}
function toastDanger(text = "Error!") {
    $.toast().reset('all');
    $("body").removeAttr('class');
    $.toast({
        heading: 'Error !',
        text: text,
        position: 'top-right',
        loaderBg: '#fec107',
        icon: 'info',
        hideAfter: 5000,
        stack: 6
    });
}

function toastSuccess(text) {
    $.toast().reset('all');
    $("body").removeAttr('class');
    $.toast({
        heading: 'Success',
        text: text,
        position: 'top-right',
        loaderBg: '#fec107',
        icon: 'success',
        hideAfter: 3500,
        stack: 6
    });
}

function toastWarning(text) {
    $.toast().reset('all');
    $("body").removeAttr('class');
    $.toast({
        heading: 'Warning',
        text: text,
        position: 'top-right',
        loaderBg: '#ff2a00',
        icon: 'warning',
        hideAfter: 3500,
        stack: 6
    });
}
(function ($) {
    $.fn.serializeObject = function () {

        var self = this,
            json = {},
            push_counters = {},
            patterns = {
                "validate": /^[a-zA-Z][a-zA-Z0-9_]*(?:\[(?:\d*|[a-zA-Z0-9_]+)\])*$/,
                "key": /[a-zA-Z0-9_]+|(?=\[\])/g,
                "push": /^$/,
                "fixed": /^\d+$/,
                "named": /^[a-zA-Z0-9_]+$/
            };


        this.build = function (base, key, value) {
            base[key] = value;
            return base;
        };

        this.push_counter = function (key) {
            if (push_counters[key] === undefined) {
                push_counters[key] = 0;
            }
            return push_counters[key]++;
        };

        $.each($(this).serializeArray(), function () {

            // skip invalid keys
            if (!patterns.validate.test(this.name)) {
                return;
            }

            var k,
                keys = this.name.match(patterns.key),
                merge = this.value,
                reverse_key = this.name;

            while ((k = keys.pop()) !== undefined) {

                // adjust reverse_key
                reverse_key = reverse_key.replace(new RegExp("\\[" + k + "\\]$"), '');

                // push
                if (k.match(patterns.push)) {
                    merge = self.build([], self.push_counter(reverse_key), merge);
                }

                // fixed
                else if (k.match(patterns.fixed)) {
                    merge = self.build([], k, merge);
                }

                // named
                else if (k.match(patterns.named)) {
                    merge = self.build({}, k, merge);
                }
            }

            json = $.extend(true, json, merge);
        });

        return json;
    };
})(jQuery);
function capitalizeFirstLetter(string) {
    return string.charAt(0).toUpperCase() + string.slice(1);
}
function setImage(src, target) {

    var mes = $(src).parent().next();
    if (src.files !== undefined && src.files[0].size > 5 * 1024 * 1024) {
        $(src).val(null);
        $(target).attr('src', "");
        $(mes).text("Maximum allowed file size is 5MB");
        return false;
    }
    $(mes).text("");
    showImage(src, target);

}
function showImage(src, target) {
    var fr = new FileReader();
    fr.onload = function () {
        target.src = fr.result;
        showRemoveImage("#" + target.id);
    }
    fr.readAsDataURL(src.files[0]);

}
function loadPaging(json, table) {

    var countData = json.data.length;
    if (countData == table.page.info().start) {
        table.page('previous').draw('page');
    }
}
/**
 * 

 */
/**
 * @param {any} inforTable:{
 *  IdTable:"",
 *  IdFrm:"",
 *  FixedColumn:"",
 *  TitleModal:"",
 *  ReadAction:"",
 *  AddAction:"",
 *  EditAction:"",
 *  DelAction:""
 *  ImportAction:"",
 *  IsManage:"",
 *  CallBackProcessData:function()
 * }
 * @param {any} inforColumn:[
 * {
 *  data:"",
 *  className:"",
 *  title:"",
 * }
 * ]
 * @param {any} conditionRead:object{}
 */
function generateTable(inforTable, inforColumn, conditionRead = {}) {

    /*Add Event*/
    if (inforTable.EditAction != null) {
        $('#' + inforTable.IdTable + ' tbody').on('click', '.btnEdit', function () {
            var model = table.row($(this).parents('tr')).data();

            addEditModel(inforTable.IdTable, inforTable.IdFrm, inforTable.TitleModal, inforTable.EditAction, model, table.row($(this).parents('tr')).index());
        });
    }
    if (inforTable.DelAction != null) {
        $('#' + inforTable.IdTable + ' tbody').on('click', '.btnDel', function () {
            var cf = confirm("Are you sure you want to delete this item?");
            if (!cf) {
                return false;
            }
            var model = table.row($(this).parents('tr')).data();
            $.ajax({
                url: inforTable.DelAction,
                type: 'POST',
                dataType: 'json',
                data: model,
                success: function success(resp) {
                    if (resp.success) {
                        var table = $('table[id="' + inforTable.IdTable + '"].tbl-crud').DataTable();
                        var tb = table.ajax.reload(function (json) {
                            var table = $('table[id="' + inforTable.IdTable + '"].tbl-crud').DataTable();
                            loadPaging(json, table);
                        }, false);
                        toastSuccess(resp.msg);
                    } else {
                        toastDanger(resp.msg);
                    }
                },
                error: function error(resp) {
                    toastDanger();
                }
            });
        });
    }
    /**/


    var ajax = {
        "url": inforTable.ReadAction,
        "type": "GET",
        "datatype": "json",
        "data": conditionRead
    };
    var table = $('#' + inforTable.IdTable).DataTable({
        keys: !0,
        ajax: ajax,
        responsive: true,
        columnDefs: [{
            "className": "dt-center align-middle text-center",
            "targets": "_all"
        }],
        order:[],
        initComplete: function (settings, json) {
            if (typeof inforTable.AddAction !== "undefined" && inforTable.AddAction != null) {
                //$('#' + inforTable.IdTable + "_length").append(' <button onclick=\'addEditModel(\"'+inforTable.IdTable + '","' + inforTable.IdFrm + '","' + inforTable.TitleModal + '","' + inforTable.AddAction + '",' + null + ',' + null+')\' class="btn btn-success btn-rounded">Add ' + inforTable.TitleModal + '</button>');
                $('#wrap-btn-add-' + inforTable.IdTable).append('<button onclick=\'addEditModel(\"' + inforTable.IdTable + '","' + inforTable.IdFrm + '","' + inforTable.TitleModal + '","' + inforTable.AddAction + '",' + null + ',' + null + ')\' class="btn btn-success btn-rounded" style=\"margin-left:10px\">Add ' + inforTable.TitleModal + '</button>');
            }
        },
        columns: inforColumn,
    });

    //if (typeof extendActions !== "undefined" && extendActions !== null) {
    //    if (extendActions.length > 0) {
    //        extendActions.forEach(function (item) {
    //            item.action(inforTable.IdTable, table);
    //        });
    //    }
    //}
    //if (typeof inforTable.ImportAction !== "undefined" && inforTable.ImportAction !== null) {
    //    var formExport = document.createElement('form');
    //    formExport.id = "form-export-" + exportExcell;


    //    var wrapExport = document.createElement('div');
    //    wrapExport.className = '';
    //    wrapExport.id = "wrap-export-" + inforTable.IdTable;

    //    var divInputFile = document.createElement('div');
    //    divInputFile.className = "custom-file";
    //    divInputFile.innerHTML = "<input name=\"file\" onchange=\"importChange(this,'" + exportExcell + "')\" type=\"file\" class=\"custom-file-input\" id=\"import-" + exportExcell + "\" accept=\"application/vnd.openxmlformats-officedocument.spreadsheetml.sheet,application/vnd.ms-excel\"><label id=\"label-import-" + exportExcell + "\" class=\"custom-file-label\" for=\"import-" + exportExcell + "\" > Choose file import</label >";
    //    divInputFile.style.width = 'unset';

    //    var wrapButton = document.createElement('div');
    //    wrapButton.className = " mt-2";
    //    wrapButton.id = "wrap-button-export-" + inforTable.IdTable;

    //    if (isIE() == 9) {
    //        var btnDownloadIE = document.createElement('div');
    //        btnDownloadIE.id = 'xlsxbtn-' + inforTable.IdTable;
    //        btnDownloadIE.className = "btn";
    //        wrapButton.appendChild(btnDownloadIE);
    //    }

    //    wrapExport.appendChild(divInputFile);
    //    wrapExport.appendChild(wrapButton);
    //    formExport.appendChild(wrapExport)
    //    table.table().container().appendChild(formExport);
    //}
    return table;
}

function addEditModel(iDTable, iDFrm, title, url, model, iDRow) {
    $('#heading-popup-' + iDTable).html(title);
    $('#' + iDFrm).attr("action", url);
    if (model !== null) {
        for (var propertyName in model) {
            var e = $('[name=' + capitalizeFirstLetter(propertyName) + ']');
            if ($(e).length > 0) {
                if (typeof $(e).attr("data-allowInput") === 'undefined') {
                    if ($(e).attr("hasImg") === 'true') {
                        $("#img-" + propertyName.toLowerCase() + "-" + iDFrm).prop("src", model[propertyName]);
                    } else {
                        var value = model[propertyName];
                        if (typeof value !== "undefined" && value !== null) {
                            value = $('<textarea />').html(model[propertyName].toString()).text();
                        }
                        $(e).val(value);

                        if (typeof $(e).attr("data-isSelect2") !== "undefined") {
                            $(e).attr("data-isSelect2", iDRow);
                        }
                    }
                }
            }
        }
    }

    $('#modal-add-edit-' + iDTable).modal("show");
}
$(document).ready(function () {
    $(".modal .modal-content input").keyup(function (event) {
        if (event.keyCode == 13) {
            $(this).closest('form').submit();
        }
    });
    $('.remove-image').click(function (e) {
        var formParent = $(this).closest('form')
        var elementFile = $(formParent).find('input[type=file]');
        if (typeof elementFile !== "undefined") {
            $(elementFile).val(null);
            var elememtImg = $(formParent).find('img');
            $(elememtImg).attr('src', 'data:image/jpeg;base64,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');
            showRemoveImage("#" + $(elememtImg).get(0).id);
            var elementPath2 = $(formParent).find('input[name=PicturePath2]');
            if (elementPath2.length == 0) {
                elementPath2 = $(formParent).find('input[name=ImagePath2]');
            }
            $(elementPath2).val('data:image/jpeg;base64,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');
        }
    })
})