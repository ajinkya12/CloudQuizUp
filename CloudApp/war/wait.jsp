
<!DOCTYPE html>
<html>
<head>
<script>
window.location.assign("pollForQuestion?topic="+"<%out.print(request.getParameter("topic"));%>")
</script>
</head>
<body>

<h2>AJAX</h2>
<button type="button" onclick="loadXMLDoc()">Request data</button>
<div id="myDiv"></div>

</body>
</html>
