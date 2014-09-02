
/*Create Drawable and Printable interfaces. Create abstract base class Shape implementing these interfaces. 
Then create two concrete class LineSegment and Circle Instantiate classes and make calls to functions.*/

public class Main {

	public static void main(String args[]){
		LineSegment ls=new LineSegment();
		Circle c=new Circle();
		ls.print();
		ls.draw();
		ls.setPoints(0,0,1,0);
		ls.getPoints();
		ls.getLength();
		System.out.println(ls.getArea());
		
		c.print();
		c.draw();
		c.setRC(2,1,0);
		c.displayRC();
		System.out.println("the area of circle is "+c.getArea());
		
		
	}

}
