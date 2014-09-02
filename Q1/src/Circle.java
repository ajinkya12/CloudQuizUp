
public class Circle extends Shape{
	
	public
		void displayRC(){
		 	System.out.println("The Centre of the Circle is at ("+ centreX +"," + centreY +").");
		 	System.out.println("The Radius of the Circle is "+ radius);
		}
		double getArea(){
			return 3.14*radius*radius;
		}
		
		public void print(){
			System.out.println("In class Circle.");
		}
		
		public void draw(){
			System.out.println("Drawing a Circle.");
		}
}
