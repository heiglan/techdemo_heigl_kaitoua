# techdemo_heigl_kaitoua

## Checkliste :

### Einführung und Grundlagen
- [ ] Verständnis von Continuous Delivery und dessen Bedeutung
- [ ] Unterschiede zwischen Continuous Integration, Continuous Delivery und Continuous Deployment
- [ ] CI-Anti Pattern identifizieren

### Automatisierung
- [ ] Automatisierte Builds eingerichtet
- [ ] Automatisierte Tests implementiert
- [ ] Automatisierte Deployments konfiguriert

### Testing
- [ ] Unit Tests geschrieben und automatisiert
- [ ] Integrationstests implementiert (optional)
- [ ] End-to-End Tests eingerichtet (optional)

### Deployment-Strategien
- [ ] Deployment-Strategien identifizieren
- [ ] Rollback-Strategien (optional)

### Containerisierung
- [ ] Docker oder ähnliche Technologien eingesetzt
- [ ] Integration in eine Build-Pipeline

### Konfigurationsmanagement
- [ ] Konfigurationsdateien versioniert und zentralisiert
- [ ] Verwendung in einer Build-Pipeline

### Feedback-Schleifen & Benachrichtigungen
- [ ] Feedback von Stakeholdern eingeholt und implementiert
- [ ] Developer Benachrichtigungen

### Sicherheit
- [ ] Zugangsdaten sicher hinterlegt

### Datenbanken
- [ ] Datenbank-Migrationen automatisiert
- [ ] Datenbank-Backups und Recovery-Pläne

### Abschluss und Dokumentation
- [ ] Projekt-Dokumentation vervollständigt


## Dokumentation


#### Docker


docker build -t techdemo-heigl-kaitoua .
docker run -d -p 8080:80 --name my-blazor-app techdemo-heigl-kaitoua



#### Build-Pipeline

Eine Build-Pipeline ist eine Reihe von Schritten, die ausgeführt werden, um eine Anwendung zu bauen. Dies kann durch die Verwendung von Build-Servern wie Jenkins oder TeamCity erreicht werden. Diese Server können so konfiguriert werden, dass sie bei jedem Code-Check-in einen Build auslösen. Dies stellt sicher, dass die Software jederzeit gebaut werden kann.
