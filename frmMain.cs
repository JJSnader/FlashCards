using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class frmMain : Form
    {
        private Timer _timer;
        private Random _r;
        private Problem _currentProblem;
        private int _problemsSolved;
        private long _totalSeconds;
        private int _currentOpCount;
        private char _currentOp;
        private int _secondsShown;
        private List<Problem> _reg_tables;
        private List<Problem> _div_tables;
        private List<Problem> _master;
        private List<Problem> _div_master;
        private int _nextProblem;

        private const int MAX_VALUE = 12;

        public frmMain()
        {
            InitializeComponent();
            _reg_tables = new List<Problem>();
            _div_tables = new List<Problem>();
            _master = new List<Problem>();
            _div_master = new List<Problem>();
            _r = new Random(DateTime.Now.GetHashCode());
            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += _timer_Tick;
            _problemsSolved = 0;
            lbProblem.Text = "";
            _currentOp = 'x';
            for (int i = 0; i <= MAX_VALUE; ++i)
            {
                for (int j = 0; j < i + 1; ++j)
                {
                    _reg_tables.Add(new Problem(i, j));
                    _master.Add(new Problem(i, j));
                    if (i > 1 && j > 0)
                    {
                        AddNewProblem(_div_tables, new Problem(i * j, i));
                        AddNewProblem(_div_master, new Problem(i * j, i));
                        AddNewProblem(_div_tables, new Problem(i * j, j));
                        AddNewProblem(_div_master, new Problem(i * j, j));
                    }
                }
            }
        }

        private void AddNewProblem(List<Problem> masterList, Problem p)
        {
            foreach (Problem b in masterList)
                if (b.FirstOp == p.FirstOp && b.SecondOp == p.SecondOp)
                    return;
            masterList.Add(p);
        }

        private void ShowNewProblem()
        {
            int nextProblem = -1;
            if (_currentOp == '/')
                nextProblem = _r.Next(0, _div_tables.Count);
            else
                nextProblem = _r.Next(0, _reg_tables.Count);

            if (!cbRandomize.Checked)
                nextProblem = _nextProblem;


            if (_currentOp == '/')
            {
                _currentProblem = _div_tables[nextProblem];
                _div_tables.Remove(_div_tables[nextProblem]);
            }
            else
            {
                _currentProblem = _reg_tables[nextProblem];
                _reg_tables.Remove(_reg_tables[nextProblem]);
            }

            //_currentProblem.FirstOp = _r.Next(0, 12);
            //_currentProblem.SecondOp = _r.Next(0, 12);

            //if (_currentOpCount == 6)
            //{
            //    _currentOpCount = 0;
            //    if (_currentOp == 'x')
            //        _currentOp = '+';
            //    else if (_currentOp == '+')
            //        _currentOp = '-';
            //    else if (_currentOp == '-')
            //        _currentOp = '/';
            //    else
            //        _currentOp = 'x';
            //}
            //else
            //    ++_currentOpCount;

            //if (_currentOp == '/' && _currentProblem.FirstOp % _currentProblem.SecondOp != 0)
            //    while (_currentProblem.FirstOp % _currentProblem.SecondOp != 0)
            //        _currentProblem.SecondOp = _r.Next(0, 12);
            //if (_currentOp == '-' && _currentProblem.FirstOp < _currentProblem.SecondOp)
            //{
            //    // prevent negatives
            //    int temp = _currentProblem.FirstOp;
            //    _currentProblem.FirstOp = _currentProblem.SecondOp;
            //    _currentProblem.SecondOp = temp;
            //}

            lbProblem.Text = _currentProblem.FirstOp.ToString() + " " + _currentOp + " " + _currentProblem.SecondOp.ToString();
        }

        private int DoOp()
        {
            switch (_currentOp)
            {
                case 'x':
                    return _currentProblem.FirstOp * _currentProblem.SecondOp;
                case '+':
                    return _currentProblem.FirstOp + _currentProblem.SecondOp;
                case '-':
                    return _currentProblem.FirstOp - _currentProblem.SecondOp;
                case '/':
                    return _currentProblem.FirstOp / _currentProblem.SecondOp;
                default:
                    return _currentProblem.FirstOp * _currentProblem.SecondOp;
            }    
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            ++_totalSeconds;

            if (_secondsShown > 0)
                ++_secondsShown;
            if (_secondsShown > 5)
            {
                lbResult.Visible = false;
                _secondsShown = 0;
            }
            
            int minutes = (int) _totalSeconds / 60;
            int seconds = (int) _totalSeconds % 60;

            lbTime.Text = string.Empty;
            if (minutes > 0)
                lbTime.Text = minutes.ToString() + ":";
            lbTime.Text += seconds.ToString();
        }

        private void tbAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            List<Keys> accepted = new List<Keys>(){ Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9, Keys.D0, Keys.Enter, Keys.Back };
            if (!accepted.Contains(e.KeyCode))
                e.SuppressKeyPress = true;
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(tbAnswer.Text))
            {
                if (tbAnswer.Text.Length < 7 && int.Parse(tbAnswer.Text) == DoOp())
                {
                    lbResult.Text = "Correct!";
                    lbResult.ForeColor = Color.LawnGreen;
                    lbResult.Visible = true;
                    ++_secondsShown;

                    ++_problemsSolved;
                    lbSolved.Text = _problemsSolved.ToString();

                    lbPrevious.Text = _currentProblem.FirstOp.ToString() + " " + _currentOp + " " + _currentProblem.SecondOp.ToString() + " = " + DoOp().ToString();
                    lbAvg.Text = (_totalSeconds / _problemsSolved).ToString();

                    if ((_currentOp == '/' && _div_tables.Count == 0) || _reg_tables.Count == 0)
                    {
                        _div_tables = _div_master;
                        _reg_tables = _master;
                        lbResult.Text = "Finished!";
                        _timer.Stop();
                        btnStart.Visible = true;
                        btnStart.Text = "Start";
                        lbProblem.Text = "";
                        cbRandomize.Visible = true;
                        rbAddition.Visible = true;
                        rbSubtraction.Visible = true;
                        rbMultiplication.Visible = true;
                        rbDivision.Visible = true;
                    }
                    else 
                        ShowNewProblem();
                }
                else
                {
                    lbResult.Text = "Wrong! Try again!";
                    lbResult.ForeColor = Color.Salmon;
                    lbResult.Visible = true;
                }
                tbAnswer.Text = "";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Start")
            {
                btnStart.Text = "Stop";
                tbAnswer.Enabled = true;
                rbAddition.Visible = false;
                rbSubtraction.Visible = false;
                rbMultiplication.Visible = false;
                rbDivision.Visible = false;
                cbRandomize.Visible = false;
                tbAnswer.Focus();
                if (string.IsNullOrEmpty(lbProblem.Text))
                    ShowNewProblem();
                _timer.Start();
            }
            else
            {
                btnStart.Text = "Start";
                tbAnswer.Enabled = false;
                _timer.Stop();
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton s = (RadioButton)sender;
            if (s != null && s.Checked)
            {
                if (s == rbAddition)
                    _currentOp = '+';
                else if (s == rbSubtraction)
                    _currentOp = '-';
                else if (s == rbMultiplication)
                    _currentOp = 'x';
                else if (s == rbDivision)
                    _currentOp = '/';
            }
        }
    }

    public class Problem
    {
        public int FirstOp { get; set; }
        public int SecondOp { get; set; }

        public Problem(int firstOp, int secondOp)
        {
            FirstOp = firstOp;
            SecondOp = secondOp;
        }
    }
}
