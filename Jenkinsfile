pipeline {
  agent {
    node {
      label 'master'
    }

  }
  stages {
    stage('sleep') {
      steps {
        sleep 2
      }
    }

    stage('force error') {
      steps {
        error 'forced fail'
      }
    }

  }
}