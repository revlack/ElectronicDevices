import React, { Component } from 'react';
import logo from '../logo.svg';
import { Link } from 'react-router-dom';

class DinamicMessage extends Component {

  constructor(props){    
    super(props)
    this.state = {
      showSecond:0,
      showstart:false
     };

     setInterval(() => {
      if(this.state.showSecond < 30)
      {
        if(this.state.showSecond > 26 &&  this.state.showstart ===false){
          this.setState({showstart:true});
        }
        this.setState({showSecond:this.state.showSecond + 1});
      }
      }, 1000);
  }

  render() {    
    return (
        <React.Fragment>
          <img src={logo} className="App-logo" alt="logo" />
          <p>
           {Message(this.state.showSecond)}
          </p>
         {this.state.showstart === true ? 
          <Link Class="white" to={"/DeviceSearch"}>Start Application</Link>          
         : "  "
           } 
        </React.Fragment>
    );
  }
}

function Message(segundo){
  if(segundo<4){
    return "Hi there! Here is me, Leandro" ;
  }else if(segundo<8){
    return "How are you?";  
  }else if(segundo<12){
  return "Design isn't our focus here, ok?";  
  }else if(segundo<16){
  return "I didn't have enough time to build something big here";
  }else if(segundo<19){
  return "That's why I'll use this React html template";
  }else if(segundo<23){
  return "I hope you guys enjoy my development";
  }else if(segundo<27){
  return "Don't forget to start the aspnet.core API and change all consts/configs";
  }
  else{
    return "Now you guys can click on 'Start Application' to start my small application!";
  }
}

export default DinamicMessage;
