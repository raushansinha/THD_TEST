import React, { Component } from 'react';
import Dropdown from 'react-dropdown';


class BandAColor extends Component {

    constructor(props) {
        super();

        this.state = {
            selectedColor: 0,
        }
    }
   

    handleSelect = (selectedColor) => {
        this.setState({ selectedColor });
        this.props.onBandColorSelect(selectedColor.value);
    }

    render() {
        const { selectedColor } = this.state;

        return (
            <Dropdown options={this.props.options} 
                      value={selectedColor} 
                      onChange={this.handleSelect} />
        );
    }
}

export default BandAColor;