using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SokoBan
{
    public class Controller
    {
        private InputView inputView;
        private OutputView outputView;
        private Maze maze;

        public Controller()
        {
            inputView = new InputView();
            outputView = new OutputView();

        }
    }
}