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
 
        stage('Build Docker Image') {
            steps {
                script {
                    docker.build('emp-img', '-f Employee_API/Dockerfile .')  
                }
            }
        }
 
        stage('Run Docker Container') {
            steps {
                script {
                    docker.image('emp-img').run('-p 8080:80')
                }
            }
        }
    }
}
