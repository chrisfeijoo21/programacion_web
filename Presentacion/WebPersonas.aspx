<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebPersonas.aspx.cs" Inherits="Presentacion.WebPersonas" %>

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

    <div class="container">
        <br />
        <div class="col-md-12">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <h3 class="panel-title">Personas</h3>
                    <span class="pull-right clickable"><i class="glyphicon glyphicon-chevron-up"></i></span>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <asp:Label CssClass="col-md-2 control-label" ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
                        <div class="col-md-4">
                            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <asp:Label CssClass="col-md-2 control-label" ID="lblApellido" runat="server" Text="Apellido:"></asp:Label>
                        <div class="col-md-4">
                            <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <br />
                    <div class="form-group">
                        <asp:Label CssClass="col-md-2 control-label" ID="lblDireccion" runat="server" Text="Direccion:"></asp:Label>
                        <div class="col-md-4">
                            <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <asp:Label CssClass="col-md-2 control-label" ID="lblTelefono" runat="server" Text="Telefono:"></asp:Label>
                        <div class="col-md-4">
                            <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <br />
                    
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-4">
                            <asp:Button CssClass="btn btn-info" ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                        </div>
                        <div class="col-md-offset-2 col-md-4">
                            <asp:Button CssClass="btn btn-info" ID="btnMostrar" runat="server" Text="Mostrar" OnClick="btnMostrar_Click" />
                        </div>
                        <br />

                        <div class="col-md-offset-2 col-md-4">
                            <asp:Button CssClass="btn btn-info" ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
                        </div>
                    </div>
                    <br />

                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-8">
                            <asp:GridView ID="gdvGrilla" runat="server" Visible=" true" AutoGenerateColumns="false" EmptyDataText="No Hay Nada" CssClass="table">
                                <Columns>
                                    <asp:BoundField HeaderText="Nombre" DataField="nombre" />
                                    <asp:BoundField HeaderText="Apellido" DataField="apellido" />
                                    <asp:BoundField HeaderText="Direccion" DataField="direccion" />
                                    <asp:BoundField HeaderText="Telefono" DataField="telefono" />
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

</asp:Content>
