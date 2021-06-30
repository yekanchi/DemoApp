pipeline {
  agent {
    node {
      label 'master'
    }

  }
  stages {
    stage('sleep') {
      when {
        expression {
          env.BRANCH_NAME == 'master'
        }

      }
      steps {
        sleep 2
      }
    }

    stage('force error') {
      environment {
        fdgfdg = 'dfgdfg'
      }
      steps {
        error 'forced fail'
      }
    }

  }
}