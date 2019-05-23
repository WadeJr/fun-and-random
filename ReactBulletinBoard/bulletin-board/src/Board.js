import React, { Component } from 'react'
import Note from './Note'

export default class Board extends Component {
    constructor(props){
        super(props)
        this.state = {
            notes: [
                {
                    id: 3,
                    note: 'Call Lisa'
                }, 
                {
                    id: 4,
                    note: 'Email John'
                },
                {
                    id: 5,
                    note: 'Order printer ink'
                }
            ]
        }

        this.eachNote = this.eachNote.bind(this)
        this.update = this.update.bind(this)

    }

    update(newText, i) {
        this.setState(prevState => ({
            notes: prevState.notes.map(
                note => (note.id !== i) ? note : {...note, note: newText}
            )
        }))
    }

    eachNote(note, i) {
        return (
        <Note key={i} index={i} onChange={this.update}>
            {note.note}
        </Note>
        )
    }


    render() {
        return (
            <div className='board'>
                {this.state.notes.map(this.eachNote)}
            </div>
        )
    }
}
