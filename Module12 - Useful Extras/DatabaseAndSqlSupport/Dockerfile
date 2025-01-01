# Use the official Microsoft SQL Server image as the base image
FROM mcr.microsoft.com/mssql/server:2022-latest

# Set environment variables
ENV ACCEPT_EULA=Y
ENV SA_PASSWORD=YourStrong@Passw0rd
ENV MSSQL_PID=Express

# Create a working directory for the database files
WORKDIR /var/opt/mssql/data

# Copy the AdventureWorksLT2022.bak file into the container
COPY AdventureWorksLT2022.bak /var/opt/mssql/data/

# Add a script to restore the database
COPY restore-database.sql /var/opt/mssql/data/restore-database.sql

# Run the SQL Server and restore the database during image build
RUN (/opt/mssql/bin/sqlservr --accept-eula & \
    for i in {1..50}; do \
        /opt/mssql-tools18/bin/sqlcmd -S localhost -U SA -P "YourStrong@Passw0rd" -Q "SELECT 1" -C && break || sleep 2; \
    done && \
    /opt/mssql-tools18/bin/sqlcmd -S localhost -U SA -P "YourStrong@Passw0rd" -i /var/opt/mssql/data/restore-database.sql -C && \
    pkill sqlservr)

# Expose SQL Server port
EXPOSE 1433

# Start SQL Server when the container runs
CMD ["/opt/mssql/bin/sqlservr"]
