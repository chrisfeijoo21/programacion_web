<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebTurnos.aspx.cs" Inherits="Presentacion.WebTurnos" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .row {
            margin-top: 40px;
            padding: 0 10px;
        }

        .clickable {
            cursor: pointer;
        }

        .panel-heading span {
            margin-top: -20px;
            font-size: 15px;
        }
    </style>
    <style>
        body {
            padding: 10px;
        }

        .show-on-hover:hover > ul.dropdown-menu {
            display: block;
        }
    </style>
    <div class="container">
        <br />
        <div class="col-md-12">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <h3 class="panel-title">Turnos</h3>
                    <span class="pull-right clickable"><i class="glyphicon glyphicon-chevron-up"></i></span>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <asp:Label CssClass="col-md-2 control-label" ID="lblPersonasCargadas" runat="server" Text="Personas Cargadas"></asp:Label>
                        <div class="row">
                            <asp:DropDownList CssClass="col-md-4 btn-default" ID="ddlPersonas" runat="server"></asp:DropDownList>
                        </div>
                        <div class="col-md-offset-2 col-md-2">
                            <asp:Button CssClass="btn btn-info" ID="btnBuscarPersona" runat="server" Text="Buscar" OnClick="btnBuscarPersona_Click" />
                        </div>
                    </div>
                    <br />
                    <div class="form-group">
                        <asp:Label CssClass="col-md-2 control-label" ID="lblFechaRegistro" runat="server" Text="Fecha de Registro:"></asp:Label>
                        <div class="col-md-4">
                            <div class="input-group date" data-provide="datepicker">
                                <input id="dtp_FechaRegistro" runat="server" type="text" class="form-control">
                                <div class="input-group-addon">
                                    <span class="glyphicon glyphicon-th"></span>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label CssClass="col-md-2 control-label" ID="lblFechaTurno" runat="server" Text="Fecha de Turno:"></asp:Label>
                        <div class="col-md-4">
                            <div class="input-group date" data-provide="datepicker">
                                <input id="dtp_FechaTurno" runat="server" type="text" class="form-control">
                                <div class="input-group-addon">
                                    <span class="glyphicon glyphicon-th"></span>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label CssClass="col-md-2 control-label" ID="lblMotivoTurno" runat="server" Text="Motivo del Turno :"></asp:Label>
                        <div class="col-md-4">
                            <asp:TextBox ID="txtMotivoTurno" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <asp:Label CssClass="col-md-2 control-label" ID="lblTareas" runat="server" Text="Tareas :"></asp:Label>
                        <div class="col-md-4">
                            <asp:TextBox ID="txtTareas" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-8">
                            <asp:GridView ID="gdvGrillaCambio" runat="server" Visible=" true" AutoGenerateColumns="false" EmptyDataText="No Hay Nada" CssClass="table">
                                <Columns>
                                    <asp:BoundField HeaderText="Persona" DataField="personas" />
                                    <asp:BoundField HeaderText="FechaRegistro" DataField="fechaRegistro" />
                                    <asp:BoundField HeaderText="FechaTurno" DataField="fechaTurno" />
                                    <asp:BoundField HeaderText="MotivoTurno" DataField="motivoTurno" />
                                    <asp:BoundField HeaderText="Tareas" DataField="tareas" />
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script>
        $(document).on('click', '.panel-heading span.clickable', function (e) {
            var $this = $(this);
            if (!$this.hasClass('panel-collapsed')) {
                $this.parents('.panel').find('.panel-body').slideUp();
                $this.addClass('panel-collapsed');
                $this.find('i').removeClass('glyphicon-chevron-up').addClass('glyphicon-chevron-down');
            } else {
                $this.parents('.panel').find('.panel-body').slideDown();
                $this.removeClass('panel-collapsed');
                $this.find('i').removeClass('glyphicon-chevron-down').addClass('glyphicon-chevron-up');
            }
        })
    </script>
    <script type="text/javascript">
        $('.datepicker').datepicker();
    </script>
    <script>
        $('#sandbox-container .input-group.date').datepicker({
            format: "dd/mm/yyyy",
            language: "es",
            multidateSeparator: "-",
            keyboardNavigation: false,
            autoclose: true,
            todayHighlight: true
        });
    </script>
</asp:Content>
