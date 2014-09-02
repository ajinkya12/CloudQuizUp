
public class LineSegment extends Shape{
	public
		void getPoints(){
			System.out.println("the end points of line segment are ("+ pt1x +","+ pt1y+ ") ,("+ pt2x+ ","+ pt2y+ ")");
		}
		void getLength(){
			System.out.println("the length of line segment is "+Math.sqrt((pt1x-pt2x)*(pt1x-pt2x) + (pt1y-pt2y)*(pt1y-pt2y)));	
		}
		double getArea(){
			return 0;
		}
		public void print(){
			System.out.println("In class LineSegment.");
		}
		
		public void draw(){
			System.out.println("Drawing a LineSegment.");
		}
}