using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using Brushes = System.Windows.Media.Brushes;


namespace Comparison_of_Sorting_Algorithms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Cài Đặt Màu Nền
            cartesianChart1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));

            // Đặt Tên Trục Hoành
            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Số Lượng Phần Tử"

            });

            // Đặt Tên Trục Tung
            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Thời Gian (ms)"

            });

            // Hiển Thị Chú Giải Bên Phải
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Pen pen1 = new System.Drawing.Pen(System.Drawing.Color.Black, 1);
            e.Graphics.DrawLine(pen1, 300, 44, 300, 215);
            e.Graphics.DrawLine(pen1, 900, 44, 900, 215);
            e.Graphics.DrawLine(pen1, 0, 222, 1200, 222);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbbxPick_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbxPick.SelectedIndex == 0)
            {
                panelAlgo.Visible = true;
                panelAlgo.Enabled = true;
                rdoBtnBasic.Visible = false;
                rdoBtnAdvance.Visible = false;

                rdoBtnBasic.Checked = false;
                rdoBtnAdvance.Checked = false;

                rdoBtnBubble.Visible = true;
                rdoBtnInsertion.Visible = true;
                rdoBtnSelection.Visible = true;
                rdoBtnShaker.Visible = true;
                rdoBtnHeap.Visible = true;
                rdoBtnQuick.Visible = true;
                rdoBtnRadix.Visible = true;
                rdoBtnMerge.Visible = true;
            }
            if(cbbxPick.SelectedIndex == 1)
            {
                panelAlgo.Visible = true;
                panelAlgo.Enabled = false;
                rdoBtnBasic.Visible = true;
                rdoBtnAdvance.Visible = true;

                rdoBtnBubble.Checked = false;
                rdoBtnInsertion.Checked = false;
                rdoBtnSelection.Checked = false;
                rdoBtnShaker.Checked = false;
                rdoBtnHeap.Checked = false;
                rdoBtnQuick.Checked = false;
                rdoBtnRadix.Checked = false;
                rdoBtnMerge.Checked = false;
            }
        }

        private void rdoBtnBasic_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoBtnBasic.Checked)
            {
                rdoBtnBubble.Visible = true;
                rdoBtnInsertion.Visible = true;
                rdoBtnSelection.Visible = true;
                rdoBtnShaker.Visible = true;

                rdoBtnHeap.Visible = false;
                rdoBtnQuick.Visible = false;
                rdoBtnRadix.Visible = false;
                rdoBtnMerge.Visible = false;
            }
        }

        private void rdoBtnAdvance_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBtnAdvance.Checked)
            {
                rdoBtnBubble.Visible = false;
                rdoBtnInsertion.Visible = false;
                rdoBtnSelection.Visible = false;
                rdoBtnShaker.Visible = false;

                rdoBtnHeap.Visible = true;
                rdoBtnQuick.Visible = true;
                rdoBtnRadix.Visible = true;
                rdoBtnMerge.Visible = true;
            }
        }

        private void btnExe_Click(object sender, EventArgs e)
        {
            // Thông Báo Nếu Chưa Chọn
            if(cbbxPick.SelectedIndex == -1)
            {
                MessageBox.Show("Vui Lòng Chọn Đầy Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbxPick.Focus();
            }
            // Xử Lý Lựa Chọn
            else if(cbbxPick.SelectedIndex != -1)
            {
                // Xây Dựng Mảng Cho Thuật Toán Cơ Bản
                int size10k = 10000;
                int size20k = 20000;
                int size30k = 30000;
                int size40k = 40000;
                int size50k = 50000;

                // Tạo Và Random Giá Trị Cho Mảng Gốc
                int[] data10k = new int[size10k];
                Build(data10k, size10k);
                int[] data20k = new int[size20k];
                Build(data20k, size20k);
                int[] data30k = new int[size30k];
                Build(data30k, size30k);
                int[] data40k = new int[size40k];
                Build(data40k, size40k);
                int[] data50k = new int[size50k];
                Build(data50k, size50k);

                // Sao Chép Giá Trị Từ Mảng Gốc Ra Mảng Phụ Từng Thuật Toán Để Đảm Bảo Công Bằng Nhất Có Thể
                int[] data10kBubble = new int[size10k];
                Array.Copy(data10k, data10kBubble, size10k);
                int[] data20kBubble = new int[size20k];
                Array.Copy(data20k, data20kBubble, size20k);
                int[] data30kBubble = new int[size30k];
                Array.Copy(data30k, data30kBubble, size30k);
                int[] data40kBubble = new int[size40k];
                Array.Copy(data40k, data40kBubble, size40k);
                int[] data50kBubble = new int[size50k];
                Array.Copy(data50k, data50kBubble, size50k);

                int[] data10kSelection = new int[size10k];
                Array.Copy(data10k, data10kSelection, size10k);
                int[] data20kSelection = new int[size20k];
                Array.Copy(data20k, data20kSelection, size20k);
                int[] data30kSelection = new int[size30k];
                Array.Copy(data30k, data30kSelection, size30k);
                int[] data40kSelection = new int[size40k];
                Array.Copy(data40k, data40kSelection, size40k);
                int[] data50kSelection = new int[size50k];
                Array.Copy(data50k, data50kSelection, size50k);

                int[] data10kInsertion = new int[size10k];
                Array.Copy(data10k, data10kInsertion, size10k);
                int[] data20kInsertion = new int[size20k];
                Array.Copy(data20k, data20kInsertion, size20k);
                int[] data30kInsertion = new int[size30k];
                Array.Copy(data30k, data30kInsertion, size30k);
                int[] data40kInsertion = new int[size40k];
                Array.Copy(data40k, data40kInsertion, size40k);
                int[] data50kInsertion = new int[size50k];
                Array.Copy(data50k, data50kInsertion, size50k);

                int[] data10kShaker = new int[size10k];
                Array.Copy(data10k, data10kShaker, size10k);
                int[] data20kShaker = new int[size20k];
                Array.Copy(data20k, data20kShaker, size20k);
                int[] data30kShaker = new int[size30k];
                Array.Copy(data30k, data30kShaker, size30k);
                int[] data40kShaker = new int[size40k];
                Array.Copy(data40k, data40kShaker, size40k);
                int[] data50kShaker = new int[size50k];
                Array.Copy(data50k, data50kShaker, size50k);

                // Xây Dựng Mảng Cho Thuật Toán Nâng Cao
                int size200k = 200000;
                int size400k = 400000;
                int size600k = 600000;
                int size800k = 800000;
                int size1000k = 1000000;

                // Tạo Và Random Giá Trị Cho Mảng Gốc
                int[] data200k = new int[size200k];
                Build(data200k, size200k);
                int[] data400k = new int[size400k];
                Build(data400k, size400k);
                int[] data600k = new int[size600k];
                Build(data600k, size600k);
                int[] data800k = new int[size800k];
                Build(data800k, size800k);
                int[] data1000k = new int[size1000k];
                Build(data1000k, size1000k);

                // Sao Chép Giá Trị Từ Mảng Gốc Ra Mảng Phụ Từng Thuật Toán
                int[] data200kMerge = new int[size200k];
                Array.Copy(data200k, data200kMerge, size200k);
                int[] data400kMerge = new int[size400k];
                Array.Copy(data400k, data400kMerge, size400k);
                int[] data600kMerge = new int[size600k];
                Array.Copy(data600k, data600kMerge, size600k);
                int[] data800kMerge = new int[size800k];
                Array.Copy(data800k, data800kMerge, size800k);
                int[] data1000kMerge = new int[size1000k];
                Array.Copy(data1000k, data1000kMerge, size1000k);

                int[] data200kHeap = new int[size200k];
                Array.Copy(data200k, data200kHeap, size200k);
                int[] data400kHeap = new int[size400k];
                Array.Copy(data400k, data400kHeap, size400k);
                int[] data600kHeap = new int[size600k];
                Array.Copy(data600k, data600kHeap, size600k);
                int[] data800kHeap = new int[size800k];
                Array.Copy(data800k, data800kHeap, size800k);
                int[] data1000kHeap = new int[size1000k];
                Array.Copy(data1000k, data1000kHeap, size1000k);

                int[] data200kRadix = new int[size200k];
                Array.Copy(data200k, data200kRadix, size200k);
                int[] data400kRadix = new int[size400k];
                Array.Copy(data400k, data400kRadix, size400k);
                int[] data600kRadix = new int[size600k];
                Array.Copy(data600k, data600kRadix, size600k);
                int[] data800kRadix = new int[size800k];
                Array.Copy(data800k, data800kRadix, size800k);
                int[] data1000kRadix = new int[size1000k];
                Array.Copy(data1000k, data1000kRadix, size1000k);

                int[] data200kQuick = new int[size200k];
                Array.Copy(data200k, data200kQuick, size200k);
                int[] data400kQuick = new int[size400k];
                Array.Copy(data400k, data400kQuick, size400k);
                int[] data600kQuick = new int[size600k];
                Array.Copy(data600k, data600kQuick, size600k);
                int[] data800kQuick = new int[size800k];
                Array.Copy(data800k, data800kQuick, size800k);
                int[] data1000kQuick = new int[size1000k];
                Array.Copy(data1000k, data1000kQuick, size1000k);

                // Nếu Chọn 1 Thuật Toán
                if (cbbxPick.SelectedIndex == 0)
                {
                    // Thông Báo Nếu Chưa Chọn Thuật Toán
                    if(rdoBtnBubble.Checked == false && rdoBtnSelection.Checked == false && rdoBtnInsertion.Checked == false && rdoBtnShaker.Checked == false 
                        && rdoBtnHeap.Checked == false && rdoBtnMerge.Checked == false && rdoBtnQuick.Checked == false && rdoBtnRadix.Checked == false)
                    {
                        MessageBox.Show("Vui Lòng Chọn Đầy Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        cartesianChart1.Visible = true;
                        
                        // Với Thuật Toán Được Chọn, UD Sẽ Vẽ 5 Điểm
                        //Basic
                        if(rdoBtnBubble.Checked)
                        {
                            cartesianChart1.Series = new SeriesCollection
                            {
                                new LineSeries
                                {
                                    Values = new ChartValues<ObservablePoint>
                                    {
                                        // Xác Định 5 Điểm Cần Vẽ
                                        new ObservablePoint(0, 0),
                                        new ObservablePoint(10000, GetTimeBubbleSort(data10kBubble)),
                                        new ObservablePoint(20000, GetTimeBubbleSort(data20kBubble)),
                                        new ObservablePoint(30000, GetTimeBubbleSort(data30kBubble)),
                                        new ObservablePoint(40000, GetTimeBubbleSort(data40kBubble)),
                                        new ObservablePoint(50000, GetTimeBubbleSort(data50kBubble))
                                    },
                                    PointGeometrySize = 15, // Kích Thước Chấm Tại Điểm
                                    Fill = Brushes.Transparent, // Là Trong Phần Diện Tích Phía Dưới
                                    Title = "Bubble Sort" // Đặt Tên Cho Đường
                                }
                            };
                        }
                        else if (rdoBtnSelection.Checked)
                        {
                            cartesianChart1.Series = new SeriesCollection
                            {
                                new LineSeries
                                {
                                    Values = new ChartValues<ObservablePoint>
                                    {
                                        new ObservablePoint(0, 0),
                                        new ObservablePoint(10000, GetTimeSelectionSort(data10kSelection)),
                                        new ObservablePoint(20000, GetTimeSelectionSort(data20kSelection)),
                                        new ObservablePoint(30000, GetTimeSelectionSort(data30kSelection)),
                                        new ObservablePoint(40000, GetTimeSelectionSort(data40kSelection)),
                                        new ObservablePoint(50000, GetTimeSelectionSort(data50kSelection))
                                    },
                                    PointGeometrySize = 15,
                                    Fill = Brushes.Transparent,
                                    Title = "Selection Sort"
                                }
                            };
                        }
                        else if (rdoBtnInsertion.Checked)
                        {
                            cartesianChart1.Series = new SeriesCollection
                            {
                                new LineSeries
                                {
                                    Values = new ChartValues<ObservablePoint>
                                    {
                                        new ObservablePoint(0, 0),
                                        new ObservablePoint(10000, GetTimeInsertionSort(data10kInsertion)),
                                        new ObservablePoint(20000, GetTimeInsertionSort(data20kInsertion)),
                                        new ObservablePoint(30000, GetTimeInsertionSort(data30kInsertion)),
                                        new ObservablePoint(40000, GetTimeInsertionSort(data40kInsertion)),
                                        new ObservablePoint(50000, GetTimeInsertionSort(data50kInsertion))
                                    },
                                    PointGeometrySize = 15,
                                    Fill = Brushes.Transparent,
                                    Title = "Insertion Sort"
                                }
                            };
                        }
                        else if (rdoBtnShaker.Checked)
                        {
                            cartesianChart1.Series = new SeriesCollection
                            {
                                new LineSeries
                                {
                                    Values = new ChartValues<ObservablePoint>
                                    {
                                        new ObservablePoint(0, 0),
                                        new ObservablePoint(10000, GetTimeCocktailShakerSort(data10kShaker)),
                                        new ObservablePoint(20000, GetTimeCocktailShakerSort(data20kShaker)),
                                        new ObservablePoint(30000, GetTimeCocktailShakerSort(data30kShaker)),
                                        new ObservablePoint(40000, GetTimeCocktailShakerSort(data40kShaker)),
                                        new ObservablePoint(50000, GetTimeCocktailShakerSort(data50kShaker))
                                    },
                                    PointGeometrySize = 15,
                                    Fill = Brushes.Transparent,
                                    Title = "Cocktail Shaker Sort"
                                }
                            };
                        }

                        //Advance
                        else if (rdoBtnHeap.Checked)
                        {
                            cartesianChart1.Series = new SeriesCollection
                            {
                                new LineSeries
                                {
                                    Values = new ChartValues<ObservablePoint>
                                    {
                                        new ObservablePoint(0, 0),
                                        new ObservablePoint(200000, GetTimeHeapSort(data200kHeap)),
                                        new ObservablePoint(400000, GetTimeHeapSort(data400kHeap)),
                                        new ObservablePoint(600000, GetTimeHeapSort(data600kHeap)),
                                        new ObservablePoint(800000, GetTimeHeapSort(data800kHeap)),
                                        new ObservablePoint(1000000, GetTimeHeapSort(data1000kHeap))
                                    },
                                    PointGeometrySize = 15,
                                    Fill = Brushes.Transparent,
                                    Title = "Heap Sort"
                                }
                            };
                        }
                        else if (rdoBtnMerge.Checked)
                        {
                            cartesianChart1.Series = new SeriesCollection
                            {
                                new LineSeries
                                {
                                    Values = new ChartValues<ObservablePoint>
                                    {
                                        new ObservablePoint(0, 0),
                                        new ObservablePoint(200000, GetTimeMergeSort(data200kMerge)),
                                        new ObservablePoint(400000, GetTimeMergeSort(data400kMerge)),
                                        new ObservablePoint(600000, GetTimeMergeSort(data600kMerge)),
                                        new ObservablePoint(800000, GetTimeMergeSort(data800kMerge)),
                                        new ObservablePoint(1000000, GetTimeMergeSort(data1000kMerge))
                                    },
                                    PointGeometrySize = 15,
                                    Fill = Brushes.Transparent,
                                    Title = "Merge Sort"
                                }
                            };
                        }
                        else if (rdoBtnQuick.Checked)
                        {
                            cartesianChart1.Series = new SeriesCollection
                            {
                                new LineSeries
                                {
                                    Values = new ChartValues<ObservablePoint>
                                    {
                                        new ObservablePoint(0, 0),
                                        new ObservablePoint(200000, GetTimeQuickSort(data200kQuick)),
                                        new ObservablePoint(400000, GetTimeQuickSort(data400kQuick)),
                                        new ObservablePoint(600000, GetTimeQuickSort(data600kQuick)),
                                        new ObservablePoint(800000, GetTimeQuickSort(data800kQuick)),
                                        new ObservablePoint(1000000, GetTimeQuickSort(data1000kQuick))
                                    },
                                    PointGeometrySize = 15,
                                    Fill = Brushes.Transparent,
                                    Title = "Quick Sort"
                                }
                            };
                        }
                        else if (rdoBtnRadix.Checked)
                        {
                            cartesianChart1.Series = new SeriesCollection
                            {
                                new LineSeries
                                {
                                    Values = new ChartValues<ObservablePoint>
                                    {
                                        new ObservablePoint(0, 0),
                                        new ObservablePoint(200000, GetTimeRadixSort(data200kRadix)),
                                        new ObservablePoint(400000, GetTimeRadixSort(data400kRadix)),
                                        new ObservablePoint(600000, GetTimeRadixSort(data600kRadix)),
                                        new ObservablePoint(800000, GetTimeRadixSort(data800kRadix)),
                                        new ObservablePoint(1000000, GetTimeRadixSort(data1000kRadix))
                                    },
                                    PointGeometrySize = 15,
                                    Fill = Brushes.Transparent,
                                    Title = "Radix Sort"
                                }
                            };
                        }
                    }
                }

                // Nếu Chọn Nhiều Thuật Toán
                else if (cbbxPick.SelectedIndex == 1)
                {
                    // Thông Báo Nếu Không Chọn
                    if(rdoBtnBasic.Checked == false && rdoBtnAdvance.Checked == false)
                    {
                        MessageBox.Show("Vui Lòng Chọn Đầy Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        cartesianChart1.Visible = true;

                        // Vẽ 4 Thuật Toán Cơ Bản
                        if (rdoBtnBasic.Checked)
                        {

                            cartesianChart1.Series = new SeriesCollection
                            {
                                new LineSeries
                                {
                                    Values = new ChartValues<ObservablePoint>
                                    {
                                        new ObservablePoint(0, 0),
                                        new ObservablePoint(10000, GetTimeBubbleSort(data10kBubble)),
                                        new ObservablePoint(20000, GetTimeBubbleSort(data20kBubble)),
                                        new ObservablePoint(30000, GetTimeBubbleSort(data30kBubble)),
                                        new ObservablePoint(40000, GetTimeBubbleSort(data40kBubble)),
                                        new ObservablePoint(50000, GetTimeBubbleSort(data50kBubble))
                                    },
                                    PointGeometrySize = 15,
                                    Fill = Brushes.Transparent,
                                    Title = "Bubble Sort"
                                },
                                new LineSeries
                                {
                                    Values = new ChartValues<ObservablePoint>
                                    {
                                        new ObservablePoint(0, 0),
                                        new ObservablePoint(10000, GetTimeSelectionSort(data10kSelection)),
                                        new ObservablePoint(20000, GetTimeSelectionSort(data20kSelection)),
                                        new ObservablePoint(30000, GetTimeSelectionSort(data30kSelection)),
                                        new ObservablePoint(40000, GetTimeSelectionSort(data40kSelection)),
                                        new ObservablePoint(50000, GetTimeSelectionSort(data50kSelection))
                                    },
                                    PointGeometrySize = 15,
                                    Fill = Brushes.Transparent,
                                    Title = "Selection Sort"
                                },
                                new LineSeries
                                {
                                    Values = new ChartValues<ObservablePoint>
                                    {
                                        new ObservablePoint(0, 0),
                                        new ObservablePoint(10000, GetTimeInsertionSort(data10kInsertion)),
                                        new ObservablePoint(20000, GetTimeInsertionSort(data20kInsertion)),
                                        new ObservablePoint(30000, GetTimeInsertionSort(data30kInsertion)),
                                        new ObservablePoint(40000, GetTimeInsertionSort(data40kInsertion)),
                                        new ObservablePoint(50000, GetTimeInsertionSort(data50kInsertion))
                                    },
                                    PointGeometrySize = 15,
                                    Fill = Brushes.Transparent,
                                    Title = "Insertion Sort"
                                },
                                new LineSeries
                                {
                                    Values = new ChartValues<ObservablePoint>
                                    {
                                        new ObservablePoint(0, 0),
                                        new ObservablePoint(10000, GetTimeCocktailShakerSort(data10kShaker)),
                                        new ObservablePoint(20000, GetTimeCocktailShakerSort(data20kShaker)),
                                        new ObservablePoint(30000, GetTimeCocktailShakerSort(data30kShaker)),
                                        new ObservablePoint(40000, GetTimeCocktailShakerSort(data40kShaker)),
                                        new ObservablePoint(50000, GetTimeCocktailShakerSort(data50kShaker))
                                    },
                                    PointGeometrySize = 15,
                                    Fill = Brushes.Transparent,
                                    Title = "Cocktail Shaker Sort"
                                }
                            };
                        }

                        // Vẽ 4 Thuật Toán Nâng Cao
                        else if (rdoBtnAdvance.Checked)
                        {
                            cartesianChart1.Series = new SeriesCollection
                            {
                                new LineSeries
                                {
                                    Values = new ChartValues<ObservablePoint>
                                    {
                                        new ObservablePoint(0, 0),
                                        new ObservablePoint(200000, GetTimeHeapSort(data200kHeap)),
                                        new ObservablePoint(400000, GetTimeHeapSort(data400kHeap)),
                                        new ObservablePoint(600000, GetTimeHeapSort(data600kHeap)),
                                        new ObservablePoint(800000, GetTimeHeapSort(data800kHeap)),
                                        new ObservablePoint(1000000, GetTimeHeapSort(data1000kHeap))
                                    },
                                    PointGeometrySize = 15,
                                    Fill = Brushes.Transparent,
                                    Title = "Heap Sort"
                                },
                                new LineSeries
                                {
                                    Values = new ChartValues<ObservablePoint>
                                    {
                                        new ObservablePoint(0, 0),
                                        new ObservablePoint(200000, GetTimeMergeSort(data200kMerge)),
                                        new ObservablePoint(400000, GetTimeMergeSort(data400kMerge)),
                                        new ObservablePoint(600000, GetTimeMergeSort(data600kMerge)),
                                        new ObservablePoint(800000, GetTimeMergeSort(data800kMerge)),
                                        new ObservablePoint(1000000, GetTimeMergeSort(data1000kMerge))
                                    },
                                    PointGeometrySize = 15,
                                    Fill = Brushes.Transparent,
                                    Title = "Merge Sort"
                                },
                                new LineSeries
                                {
                                    Values = new ChartValues<ObservablePoint>
                                    {
                                        new ObservablePoint(0, 0),
                                        new ObservablePoint(200000, GetTimeQuickSort(data200kQuick)),
                                        new ObservablePoint(400000, GetTimeQuickSort(data400kQuick)),
                                        new ObservablePoint(600000, GetTimeQuickSort(data600kQuick)),
                                        new ObservablePoint(800000, GetTimeQuickSort(data800kQuick)),
                                        new ObservablePoint(1000000, GetTimeQuickSort(data1000kQuick))
                                    },
                                    PointGeometrySize = 15,
                                    Fill = Brushes.Transparent,
                                    Title = "Quick Sort"
                                },
                                new LineSeries
                                {
                                    Values = new ChartValues<ObservablePoint>
                                    {
                                        new ObservablePoint(0, 0),
                                        new ObservablePoint(200000, GetTimeRadixSort(data200kRadix)),
                                        new ObservablePoint(400000, GetTimeRadixSort(data400kRadix)),
                                        new ObservablePoint(600000, GetTimeRadixSort(data600kRadix)),
                                        new ObservablePoint(800000, GetTimeRadixSort(data800kRadix)),
                                        new ObservablePoint(1000000, GetTimeRadixSort(data1000kRadix))
                                    },
                                    PointGeometrySize = 15,
                                    Fill = Brushes.Transparent,
                                    Title = "Radix Sort"
                                }
                            };
                        }
                    }
                }   
            }

        }

        #region Xay Dung Ham Lay Thoi Gian
        private int GetTimeBubbleSort(int[] arr)
        {
            var startTime = DateTime.Now;

            BubbleSort(arr);

            var time = DateTime.Now.Subtract(startTime);
            int exeTime = (int)time.TotalMilliseconds;

            return exeTime;
        }

        private int GetTimeSelectionSort(int[] arr)
        {
            var startTime = DateTime.Now;

            SelectionSort(arr);

            var time = DateTime.Now.Subtract(startTime);
            int exeTime = (int)time.TotalMilliseconds;

            return exeTime;
        }

        private int GetTimeInsertionSort(int[] arr)
        {
            var startTime = DateTime.Now;

            InsertionSort(arr);

            var time = DateTime.Now.Subtract(startTime);
            int exeTime = (int)time.TotalMilliseconds;

            return exeTime;
        }

        private int GetTimeCocktailShakerSort(int[] arr)
        {
            var startTime = DateTime.Now;

            CocktailShakerSort(arr);

            var time = DateTime.Now.Subtract(startTime);
            int exeTime = (int)time.TotalMilliseconds;

            return exeTime;
        }

        private int GetTimeMergeSort(int[] arr)
        {
            var startTime = DateTime.Now;

            mergeSort(arr, 0, arr.Length - 1);

            var time = DateTime.Now.Subtract(startTime);
            int exeTime = (int)time.TotalMilliseconds;

            return exeTime;
        }

        private int GetTimeHeapSort(int[] arr)
        {
            var startTime = DateTime.Now;

            heapSort(arr);

            var time = DateTime.Now.Subtract(startTime);
            int exeTime = (int)time.TotalMilliseconds;

            return exeTime;
        }

        private int GetTimeRadixSort(int[] arr)
        {
            var startTime = DateTime.Now;

            radixsort(arr, arr.Length);

            var time = DateTime.Now.Subtract(startTime);
            int exeTime = (int)time.TotalMilliseconds;

            return exeTime;
        }

        private int GetTimeQuickSort(int[] arr)
        {
            var startTime = DateTime.Now;

            QuickSort(arr, 0, arr.Length - 1);

            var time = DateTime.Now.Subtract(startTime);
            int exeTime = (int)time.TotalMilliseconds;

            return exeTime;
        }
        #endregion

        #region Xay Dung Mang & Thuat Toan Sap Xep

        private void Build(int[] arrary, int size)
        {
            Random r = new Random();
            for (var i = 0; i < size; i++)
            {
                arrary[i] = r.Next(10000);
            }
        }

        //**************************************************
        //****************Sorting Algorithms****************
        //**************************************************

        //Bubble
        private void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }

        //Selection
        private void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;

                // Swap the found minimum element with the first
                // element
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
        }

        //Insertion
        private void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }

        //CocktailShaker
        private void CocktailShakerSort(int[] array)
        {
            bool isSwapped = true;
            int start = 0;
            int end = array.Length;

            while (isSwapped == true)
            {

                //Reset this flag.  
                //It is possible for this to be true from a prior iteration.
                isSwapped = false;

                //Do a bubble sort on this array, from low to high. 
                //If something changed, make isSwapped true.
                for (int i = start; i < end - 1; ++i)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        isSwapped = true;
                    }
                }

                //If no swaps are made, the array is sorted.
                if (isSwapped == false)
                    break;

                //We need to reset the isSwapped flag for the high-to-low pass
                isSwapped = false;

                //The item we just moved is in its rightful place, 
                //so we no longer need to consider it unsorted.
                end = end - 1;

                //Now we bubble sort from high to low
                for (int i = end - 1; i >= start; i--)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        isSwapped = true;
                    }
                }

                //Finally, we need to increase the starting point 
                //for the next low-to-high pass.
                start = start + 1;
            }
        }

        //Merge
        private void merge(int[] arr, int l, int m, int r)
        {
            // Find sizes of two
            // subarrays to be merged
            int n1 = m - l + 1;
            int n2 = r - m;

            // Create temp arrays
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < n1; ++i)
                L[i] = arr[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];

            // Merge the temp arrays

            // Initial indexes of first
            // and second subarrays
            i = 0;
            j = 0;

            // Initial index of merged
            // subarry array
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements
            // of L[] if any
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            // Copy remaining elements
            // of R[] if any
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
        private void mergeSort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                // Find the middle
                // point
                int m = l + (r - l) / 2;

                // Sort first and
                // second halves
                mergeSort(arr, l, m);
                mergeSort(arr, m + 1, r);

                // Merge the sorted halves
                merge(arr, l, m, r);
            }
        }

        //Heap
        private void heapSort(int[] arr)
        {
            int n = arr.Length;

            // Build heap (rearrange array)
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);

            // One by one extract an element from heap
            for (int i = n - 1; i > 0; i--)
            {
                // Move current root to end
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // call max heapify on the reduced heap
                heapify(arr, i, 0);
            }
        }
        private void heapify(int[] arr, int n, int i)
        {
            int largest = i; // Initialize largest as root
            int l = 2 * i + 1; // left = 2*i + 1
            int r = 2 * i + 2; // right = 2*i + 2

            // If left child is larger than root
            if (l < n && arr[l] > arr[largest])
                largest = l;

            // If right child is larger than largest so far
            if (r < n && arr[r] > arr[largest])
                largest = r;

            // If largest is not root
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                // Recursively heapify the affected sub-tree
                heapify(arr, n, largest);
            }
        }

        //Radix
        private int getMax(int[] arr, int n)
        {
            int mx = arr[0];
            for (int i = 1; i < n; i++)
                if (arr[i] > mx)
                    mx = arr[i];
            return mx;
        }
        private void countSort(int[] arr, int n, int exp)
        {
            int[] output = new int[n]; // output array
            int i;
            int[] count = new int[10];

            // initializing all elements of count to 0
            for (i = 0; i < 10; i++)
                count[i] = 0;

            // Store count of occurrences in count[]
            for (i = 0; i < n; i++)
                count[(arr[i] / exp) % 10]++;

            // Change count[i] so that count[i] now contains
            // actual
            //  position of this digit in output[]
            for (i = 1; i < 10; i++)
                count[i] += count[i - 1];

            // Build the output array
            for (i = n - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }

            // Copy the output array to arr[], so that arr[] now
            // contains sorted numbers according to current
            // digit
            for (i = 0; i < n; i++)
                arr[i] = output[i];
        }
        private void radixsort(int[] arr, int n)
        {
            // Find the maximum number to know number of digits
            int m = getMax(arr, n);

            // Do counting sort for every digit. Note that
            // instead of passing digit number, exp is passed.
            // exp is 10^i where i is current digit number
            for (int exp = 1; m / exp > 0; exp *= 10)
                countSort(arr, n, exp);
        }

        //Quick
        private void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    QuickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort(arr, pivot + 1, right);
                }
            }

        }
        private int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }

        #endregion
    }
}
