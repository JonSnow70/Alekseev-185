![image](https://user-images.githubusercontent.com/90375458/133039936-a756a291-17a7-46ad-a845-0acdeb014029.png)
#include <opencv2/core/core.hpp>
#include <opencv2/highgui/highgui.hpp>
#include <string>
using namespace cv;
using namespace std;
int main()
{
	int height = 520;
	int width = 840;
	Mat img(height, width, CV_8UC3);
	Point textOrg(100, img.rows / 2);
	//int fontFace = FONT_HERSHEY_PLAIN;
	double fontScale = 2;
	Scalar color(200, 100, 50);
	//putText(img, "OpenCV Step By Step", textOrg, FONT_HERSHEY_PLAIN, fontScale, color);
	namedWindow("Hello World", 0);
	imshow("Hello World", img);
	waitKey(0);
	return 0;
}
	![image](https://user-images.githubusercontent.com/90375458/133044904-b9147c98-73fe-4218-8776-a10b19dbe0e4.png)
![image](https://user-images.githubusercontent.com/90375458/133050748-8536c07c-f00e-4166-b14c-cd8507ce3ed1.png)

