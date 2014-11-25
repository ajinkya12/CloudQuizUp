<%@ page contentType="text/html;charset=UTF-8" language="java"%>
<%@ page import="java.util.*"%>
<%@ page import="java.util.List"%>
<%@ page import="com.google.appengine.api.users.User"%>
<%@ page import="com.google.appengine.api.users.UserService"%>
<%@ page import="com.google.appengine.api.users.UserServiceFactory"%>

<%@ page import="com.google.appengine.api.datastore.DatastoreService"%>
<%@ page
	import="com.google.appengine.api.datastore.DatastoreServiceFactory"%>
<%@ page import="com.google.appengine.api.datastore.Entity"%>
<%@ page import="com.google.appengine.api.datastore.FetchOptions"%>
<%@ page import="com.google.appengine.api.datastore.*"%>
<%@ page import="com.google.appengine.api.datastore.KeyFactory"%>
<%@ page import="com.google.appengine.api.datastore.Query.*"%>
<%@ page import="com.google.appengine.api.datastore.PreparedQuery"%>
<%@ page import="com.google.appengine.api.datastore.PreparedQuery"%>
<%@ page import="com.cloud.*"%>

<html>
<head>
<title>Quiz Up</title>
<link href="/css/bootstrap.min.css" rel="stylesheet">
<link href="/css/bootstrap.css" rel="stylesheet">
<script>
setInterval(function(){window.location.assign("/response?qid="+"<%out.print(request.getParameter("qid"));%>"+"&userAns=1");},10000);
</script>
</head>
<body>
	<%
		String email = new String();
		Cookie cookie = null;
		Cookie[] cookies = null;
		cookies = request.getCookies();
		if (cookies != null) 
		{
			for (int i = 0; i < cookies.length; i++) {
				cookie = cookies[i];
				if (cookie.getName().equals("email")) {
					email = cookie.getValue();
				}
			}
		}
		System.out.println("done1  " +email );
		
		DatastoreService datastore = DatastoreServiceFactory.getDatastoreService();
		int qid = Integer.parseInt(request.getParameter("qid"));
		
		FilterPredicate filter1 = new FilterPredicate("player1", FilterOperator.EQUAL, email);
		FilterPredicate filter2 = new FilterPredicate("player2", FilterOperator.EQUAL, email);
		
		
		Query q = new Query("Match").setFilter(CompositeFilterOperator.or(filter1,filter2));
		PreparedQuery pq = datastore.prepare(q);
		Entity pair = pq.asList(FetchOptions.Builder.withDefaults()).get(0);
		EmbeddedEntity temp = new EmbeddedEntity();
		temp = (EmbeddedEntity)pair.getProperty("question"+qid);
		System.out.println("done2"+temp);
		String ques = temp.getProperty("question").toString();
		String opt1 = temp.getProperty("option1").toString();
		String opt2 = temp.getProperty("option2").toString();
		String opt3 = temp.getProperty("option3").toString();
		String opt4 = temp.getProperty("option4").toString();
	%>

	<label name="question" class="form-control"
		><%out.println(ques);%></label>

	<div class="radio">
		<label> <input type="radio"
			name="option1"><a href = "/response?qid=<%out.println(qid); %>&userAns=1"><%out.println(opt1);%></a>
		</label>
	</div>
	<div class="radio">
		<label> <input type="radio"
			name="option2"><a href = "/response?qid=<%out.println(qid); %>&userAns=2">
			<%out.println(opt2);%></a>
		</label>
	</div>
	<div class="radio">
		<label> <input type="radio"
			name="option3"><a href = "/response?qid=<%out.println(qid); %>&userAns=3">
			<%out.println(opt3);%></a>
		</label>
	</div>
	<div class="radio">
		<label> <input type="radio"
			name="option4"><a href = "/response?qid=<%out.println(qid); %>&userAns=4">
			<%out.println(opt4);%></a>
		</label>
	</div>

<H3 id = "timer" ></H3>
</body>
</html>