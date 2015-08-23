using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MatrixLibrary;

namespace WindowsFormsApplication1.ANFIS {
    class PanelData {

        private Matrix data;
        private String panelName;
        private String description;
        private String [ ] variableName;

        
        public PanelData (String panelName, String description, Matrix data) {
            this.data = data;
            this.panelName = panelName;
            this.description = description;
            this.variableName = new String [ data.NoCols ];
        }

        public void updateValue (double value, int row, int col) {
            data [ row, col ] = value;
        }

        public double getValue (int row, int col) {
            return data [ row, col ];
        }

        public String getVariableName (int index) {
            return this.variableName [ index ];
        }

        public int variableCount () {
            return data.NoCols;
        }

        public int numberOfObservations () {
            return data.NoRows;
        }
    }
}
