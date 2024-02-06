<Query Kind="Statements">
  <Connection>
    <ID>b26cefde-84ef-4223-8236-bf5d28f514f6</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>.</Server>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <DeferDatabasePopulation>true</DeferDatabasePopulation>
    <Database>OMST_2018</Database>
    <DriverData>
      <LegacyMFA>false</LegacyMFA>
    </DriverData>
  </Connection>
</Query>

//	Q1 (2 minutes)
Genres
	.Select(x => new
	{
		Genres = x.Description,
		MovieCount = x.Movies.Count()
	})
	.OrderByDescending(x => x.MovieCount)
	.Dump();

//	Q2 ()
Movies
	.Where(x => x.ReleaseYear> 2000 && (x.Rating.Description == "G" || x.Rating.Description == "PG"
				|| x.Rating.Description == "14+" || x.Rating.Description == "18+"))
	.Select(x => new
	{
		Rating = x.Description == "G" ? "General"
				: x.Description == "PG" ? "Parental Guidance"
				: x.Description == "14+" ? "Parents Strongly Cautioned"
				: "NC-17"
		Count = x.Movies.Count();				
	})
	.Dump();