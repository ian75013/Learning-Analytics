import React, { Component } from "react";
import { connect } from "react-redux";
import { loadStudents } from "../actions/index";
import { Student } from "./Student";

export class StudentList extends Component {
  constructor(props) {
    super(props);
  }

  componentDidMount() {
    this.props.loadStudents();
  }

  render() {
    return (
      <ul>
        {this.props.students.map(student => (
          <Student student={student}/>
        ))}
      </ul>
    );
  }
}

function mapStateToProps(state) {
  return {
    students: state.students //.slice(0, 10)
  };
}

export default connect(
  mapStateToProps,
  { loadStudents }
)(StudentList);