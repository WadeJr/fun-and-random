import React, { Component } from 'react'
import Note from './Note'
import {FaPlusCircle} from 'react-icons/fa'

export default class Board extends Component {
    constructor(props){
        super(props)
        this.state = {
            notes: []
        }

        this.eachNote = this.eachNote.bind(this)
        this.update = this.update.bind(this)
        this.remove = this.remove.bind(this)
        this.addNote = this.addNote.bind(this)
        this.newId = this.newId.bind(this)

    }

    componentWillMount() {
        
    }

    remove(id) {
        this.setState(prevState => ({
            notes: prevState.notes.filter(note => note.id !== id)
        }))
    }

    update(newText, i) {
        this.setState(prevState => ({
            notes: prevState.notes.map(
                note => (note.id !== i) ? note : {...note, note: newText}
            )
        }))
    }

    addNote(text) {
        this.setState(prevState => ({
            notes: [
                ...prevState.notes,
                {
                    id: this.newId(),
                    note: text
                }
            ]
        }))
    }

    newId() {
        this.uniqueId = this.uniqueId || 0
        return this.uniqueId++
    }

    eachNote(note, i) {
        return (
        <Note key={i} index={i} onChange={this.update} onRemove={this.remove}>
            {note.note}
        </Note>
        )
    }


    render() {
        return (
            <div className='board'>
                {this.state.notes.map(this.eachNote)}
                <button onClick={this.addNote.bind(null, "New Note")}
                        id='add'
                >
                   <FaPlusCircle /> 
                </button>
            </div>
        )
    }
}
