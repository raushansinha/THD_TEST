import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import BandAColor from './Components/band_a_color';
import BandBColor from './Components/band_b_color';
import BandCColor from './Components/band_c_color';

// Create a new component, this should produce some HTML
class App extends Component {

  constructor(props) {
    super(props);

    this.state = {
      bandAColor: 0,
      bandBColor: 0,
      bandCColor: 0,
      resistorOhm: 0
    };

    this.getResistorOhmValue();
  }

  getResistorOhmValue() {
    console.log("A:" + this.state.bandAColor);
    console.log("B:" + this.state.bandBColor);
    console.log("C:" + this.state.bandCColor);

    fetch(`http://localhost:14010/OhmCalculator/Ohmvalue?bandAColor=${this.state.bandAColor}&bandBColor=${this.state.bandBColor}&bandCColor=${this.state.bandCColor}`)
          .then(result=>result.json())
          .then(response =>{
            console.log("Service Response: " + JSON.stringify(response));
            this.setState({resistorOhm : response.ohm});
          });

  }
  
  render() {
    // Band color and values
    const options = [
      { value: 0, label: 'Black' },
      { value: 1, label: 'Brown' },
      { value: 2, label: 'Red' },
      { value: 3, label: 'Orange' },
      { value: 4, label: 'Yellow' },
      { value: 5, label: 'Green' },
      { value: 6, label: 'Blue' },
      { value: 7, label: 'Violet' },
      { value: 8, label: 'Gray' },
      { value: 9, label: 'Whit' }
    ]

    return (
      <div>
        <div className="h4">
          Select Band Colors
        </div>
        <div className="row">
          <div className = "col-md-4">
            <BandAColor options={options} onBandColorSelect = {(colorValue) => {
                this.state.bandAColor = colorValue
                this.getResistorOhmValue();
              } 
            } />
          </div>
          <div className = "col-md-4">          
            <BandBColor options={options} onBandColorSelect = {(colorValue) => {
                  this.state.bandBColor = colorValue
                  this.getResistorOhmValue();
                } 
              } />
          </div>
          <div className = "col-md-4">
            <BandCColor options={options} onBandColorSelect = {(colorValue) => {
                this.state.bandCColor = colorValue
                this.getResistorOhmValue();
              } 
            } />
          </div>
        </div>
        <div className = "result" hidden={this.state.resistorOhm <= 0}>
           Resistor Ohm: {this.state.resistorOhm}
         </div>
      </div>
    );
  }
}

// Take generated HTML and put it on the page (in the DOM)
ReactDOM.render( < App / > , document.querySelector('.container'));
