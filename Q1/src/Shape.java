interface printable{
	void print();
}

interface drawable extends printable{
	void draw();
}

public abstract class Shape implements drawable{
	
	protected float radius,pt1x,pt1y,pt2x,pt2y,centreX,centreY;
	
	public
		void setRC(float r,float cX,float cY)
		{
			radius =r;
			centreX =cX;
			centreY =cY;
		}
		void setPoints(float p1x,float p1y,float p2x,float p2y)
		{
			pt1x =p1x;
			pt1y=p1y;
			pt2x=p2x;
			pt2y=p2y;
		}
		abstract double getArea();
}
