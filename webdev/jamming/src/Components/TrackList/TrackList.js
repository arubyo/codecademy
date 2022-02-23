import React from 'react';
import './TrackList.css';
import Track from '../Track/Track';


export class TrackList extends React.Component {

	renderMap(){
	 if (this.props.tracks){

	  return  this.props.tracks.map(track => {return <Track track={track}  key={track.id} onAdd={this.props.onAdd}/> });

	 }
	}

	render() {

	    return (

	        <div className="TrackList">
	        {this.renderMap()}
	        </div>

	    )

	}}


export default TrackList;
