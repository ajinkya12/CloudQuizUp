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


<%
DatastoreService datastore = DatastoreServiceFactory.getDatastoreService();
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

Key k = KeyFactory.createKey("OnlineUser", email);
Query q = new Query(k);
PreparedQuery pq = datastore.prepare(q);

Entity entity = pq.asList(FetchOptions.Builder.withDefaults()).get(0);

int rightAns = 0;

for(int i=1;i<=5;i++)
{
	if(entity.getProperty("answer"+i).equals("right"))
	{
		rightAns++;
	}
}
%>
<h3>Congrats!!!<br>You got <%out.print(rightAns); %></h3>