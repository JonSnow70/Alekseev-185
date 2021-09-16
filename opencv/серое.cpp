#include "opencv2/highgui/highgui.hpp"
#include "opencv2/imgproc/imgproc.hpp"
#include <iostream>
#include <stdio.h>
#include <stdlib.h>
using namespace cv;
using namespace std;
Mat img;
int main()
{
	Mat img;
	img = imread("1234.jpg", 1);
	namedWindow("Hello world", WINDOW_AUTOSIZE);
	imshow("Hello world", img);
	Mat src_gray;
	Mat canny_output;
	cvtColor(img, src_gray, COLOR_RGB2BGR);
	blur(src_gray, src_gray, Size(3, 3));
	double lower_thresh_val = 100, high_thresh_val = 300;
	Canny(src_gray, canny_output, lower_thresh_val, high_thresh_val, 3);
	namedWindow("����� �����������", WINDOW_AUTOSIZE);
	imshow("����� �����������", canny_output);
	imwrite("canny_output.jpg", canny_output);

	waitKey(0);
	system("pause");
	return(0);
}