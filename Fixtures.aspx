<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Fixtures.aspx.cs" Inherits="Fixtures" Title="Fixture List" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ph_Centre" runat="Server">
    <h1>Angel Fixture List</h1>
    <h4>Select team to highlight fixtures</h4>
    <br />
    <script>
        data = [];
        teams = [];

        function InjectTable(filter_team_name) {
            var html = '';
            for (var row = 1; row < data.length; row++) {
                if (data[row][3] == filter_team_name || filter_team_name == '') {
                    html += '<tr><td>' + data[row].join('</td><td>') + '</td></tr>';
                }
            }

            // headers
            html = '<tr><th>' + data[0].join('</th><th>') + '</th></tr>' + html;

            document.getElementById('fixtures_table').innerHTML = '<table border="1" cellpadding="0" cellspacing="0">' + html + '</table>';
        }
        function InjectFilter() {
            var html = '';
            html += '<option value="" select="select">Show all</option>';
            for (var index = 0; index < teams.length; index++) {
                html += '<option value="' + teams[index] + '">' + teams[index] + '</option>';
            }
            html = '<select class="a" onchange="InjectTable(this.value);">' + html + '</select>';
            document.getElementById('filter').innerHTML = html;
        }
        function PopulateTeams() {
            for (var row = 1; row < data.length; row++) {
                teams[teams.length] = data[row][3];
            }
            teams = teams.filter(function (item, pos, self) { return self.indexOf(item) == pos; }); // remove duplicates
            teams.sort();
        }
    </script>
    <script src="scripts/data.js"></script>
    <script>
        PopulateTeams();
    </script>
    <style>
        table {
            border-collapse: collapse;
            border: 1px solid black;
        }

        td {
            padding: 2px;
            border: 1px solid black;
        }

        th {
            border: 1px solid black;
        }
    </style>
    <div id="filter"></div>
    <div id="fixtures_table"></div>
    <script>
        InjectFilter();
        InjectTable(''); // default show all
    </script>
</asp:Content>


