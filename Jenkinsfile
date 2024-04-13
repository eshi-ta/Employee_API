pipeline {
    agent any
    stages {
        stage('Git checkout') {
            steps {
                checkout([$class: 'GitSCM',
                          branches: [[name: '*/master']],
                          doGenerateSubmoduleConfigurations: false,
                          extensions: [],
                          submoduleCfg: [],
                          userRemoteConfigs: [[url: 'https://github.com/eshi-ta/Employee_API.git']]])
            }
        }
        stage('build and test') {
            steps {
 
                     sh 'dotnet build'
            }
        }
    }
}
