using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Dino.Api.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataForDinosaurContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dinosaurs",
                columns: new[] { "Id", "Classification", "Diet", "Name", "Period" },
                values: new object[,]
                {
                    { 1, "Prosauropod", "Herbivore", "Aardonyx", "Early Jurassic" },
                    { 2, "Large theropod", "Carnivore", "Abelisaurus", "Late Cretaceous" },
                    { 3, "Ceratopsian", "Herbivore", "Achelousaurus", "Late Cretaceous" },
                    { 4, "Large theropod", "Carnivore", "Achillobator", "Late Cretaceous" },
                    { 5, "Large theropod", "Carnivore", "Acrocanthosaurus", "Early Cretaceous" },
                    { 6, "Sauropod", "Herbivore", "Aegyptosaurus", "Late Cretaceous" },
                    { 7, "Large theropod", "Carnivore", "Afrovenator", "Early Cretaceous" },
                    { 8, "Small ornithischian", "Herbivore", "Agilisaurus", "Late Jurassic" },
                    { 9, "Sauropod", "Herbivore", "Alamosaurus", "Late Cretaceous" },
                    { 10, "Ceratopsian", "Herbivore", "Albertaceratops", "Late Cretaceous" },
                    { 11, "Large theropod", "Carnivore", "Albertosaurus", "Late Cretaceous" },
                    { 12, "Large theropod", "Carnivore", "Alectrosaurus", "Late Cretaceous" },
                    { 13, "Large theropod", "Carnivore", "Alioramus", "Late Cretaceous" },
                    { 14, "Large theropod", "Carnivore", "Allosaurus", "Late Jurassic" },
                    { 15, "Small theropod", "Carnivore", "Alvarezsaurus", "Late Cretaceous" },
                    { 16, "Sauropod", "Herbivore", "Amargasaurus", "Early Cretaceous" },
                    { 17, "Prosauropod", "Herbivore", "Ammosaurus", "Early Jurassic" },
                    { 18, "Sauropod", "Herbivore", "Ampelosaurus", "Late Cretaceous" },
                    { 19, "Sauropod", "Herbivore", "Amygdalodon", "Mid Jurassic" },
                    { 20, "Ceratopsian", "Herbivore", "Anchiceratops", "Late Cretaceous" },
                    { 21, "Prosauropod", "Herbivore", "Anchisaurus", "Early Jurassic" },
                    { 22, "Armoured dinosaur", "Herbivore", "Ankylosaurus", "Late Cretaceous" },
                    { 23, "Large theropod", "Carnivore", "Anserimimus", "Late Cretaceous" },
                    { 24, "Sauropod", "Herbivore", "Antarctosaurus", "Late Cretaceous" },
                    { 25, "Sauropod", "Herbivore", "Apatosaurus", "Late Jurassic" },
                    { 26, "Sauropod", "Herbivore", "Aragosaurus", "Early Cretaceous" },
                    { 27, "Large ornithopod", "Herbivore", "Aralosaurus", "Late Cretaceous" },
                    { 28, "Ceratopsian", "Herbivore", "Archaeoceratops", "Early Cretaceous" },
                    { 29, "Small theropod", "Carnivore", "Archaeopteryx", "Late Jurassic" },
                    { 30, "Small theropod", "Carnivore", "Archaeornithomimus", "Late Cretaceous" },
                    { 31, "Sauropod", "Herbivore", "Argentinosaurus", "late Cretaceous" },
                    { 32, "Ceratopsian", "Herbivore", "Arrhinoceratops", "Late Cretaceous" },
                    { 33, "Small ornithopod", "Herbivore", "Atlascopcosaurus", "Early Cretaceous" },
                    { 34, "Large theropod", "Carnivore", "Aucasaurus", "Late Cretaceous" },
                    { 35, "Sauropod", "Herbivore", "Austrosaurus", "Early Cretaceous" },
                    { 36, "Ceratopsian", "Herbivore", "Avaceratops", "Late Cretaceous" },
                    { 37, "Small theropod", "Omnivore", "Avimimus", "Late Cretaceous" },
                    { 38, "Large ornithopod", "Herbivore", "Bactrosaurus", "Late Cretaceous" },
                    { 39, "Ceratopsian", "Herbivore", "Bagaceratops", "Late Cretaceous" },
                    { 40, "Small theropod", "Carnivore", "Bambiraptor", "Late Cretaceous" },
                    { 41, "Sauropod", "Herbivore", "Barapasaurus", "Early Jurassic" },
                    { 42, "Sauropod", "Herbivore", "Barosaurus", "Late Jurassic" },
                    { 43, "Small theropod", "Carnivore", "Baryonyx", "Early Cretaceous" },
                    { 44, "Small theropod", "Carnivore", "Becklespinax", "Early Cretaceous" },
                    { 45, "Small theropod", "Omnivore", "Beipiaosaurus", "Early Cretaceous" },
                    { 46, "Sauropod", "Herbivore", "Bellusaurus", "Mid Jurassic" },
                    { 47, "Small theropod", "Carnivore", "Borogovia", "Late Cretaceous" },
                    { 48, "Sauropod", "Herbivore", "Brachiosaurus", "Late Jurassic" },
                    { 49, "Large ornithopod", "", "Brachylopho-saurus", "" },
                    { 50, "Sauropod", "Herbivore", "Brachytrachelopan", "Mid Jurassic" },
                    { 51, "Small theropod", "Carnivore", "Buitreraptor", "Late Cretaceous" },
                    { 52, "Sauropod", "Herbivore", "Camarasaurus", "Late Jurassic" },
                    { 53, "Large ornithopod", "Herbivore", "Camptosaurus", "Late Jurassic" },
                    { 54, "Small theropod", "Carnivore", "Carcharodontosaurus", "Late Cretaceous" },
                    { 55, "Large theropod", "Carnivore", "Carnotaurus", "Late Cretaceous" },
                    { 56, "Small theropod", "Omnivore", "Caudipteryx", "Early Cretaceous" },
                    { 57, "Armoured dinosaur", "Herbivore", "Cedarpelta", "Early Cretaceous" },
                    { 58, "Ceratopsian", "Herbivore", "Centrosaurus", "Late Cretaceous" },
                    { 59, "Large theropod", "Carnivore", "Ceratosaurus", "Late Jurassic" },
                    { 60, "Sauropod", "Herbivore", "Cetiosauriscus", "Mid Jurassic" },
                    { 61, "Sauropod", "Herbivore", "Cetiosaurus", "Mid Jurassic" },
                    { 62, "Ceratopsian", "Herbivore", "Chaoyangsaurus", "Late Jurassic" },
                    { 63, "Ceratopsian", "Herbivore", "Chasmosaurus", "Late Cretaceous" },
                    { 64, "Early dinosaur", "Carnivore", "Chindesaurus", "Late Triassic" },
                    { 65, "Sauropod", "Herbivore", "Chinshakiangosaurus", "Late Jurassic" },
                    { 66, "Small theropod", "Omnivore", "Chirostenotes", "Late Jurassic" },
                    { 67, "Sauropod", "Herbivore", "Chubutisaurus", "Early Cretaceous" },
                    { 68, "Armoured dinosaur", "Herbivore", "Chungkingosaurus", "Late Jurassic" },
                    { 69, "Small theropod", "Omnivore", "Citipati", "Late Cretaceous" },
                    { 70, "Small theropod", "Carnivore", "Coelophysis", "Late Triassic" },
                    { 71, "Small theropod", "Carnivore", "Coelurus", "Late Jurassic" },
                    { 72, "Prosauropod", "Omnivore", "Coloradisaurus", "Late Triassic" },
                    { 73, "Small theropod", "Carnivore", "Compsognathus", "Late Jurassic" },
                    { 74, "Small theropod", "Carnivore", "Conchoraptor", "Late Cretaceous" },
                    { 75, "Small theropod", "Carnivore", "Confuciusornis", "Early Cretaceous" },
                    { 76, "Large ornithopod", "Herbivore", "Corythosaurus", "Late Cretaceous" },
                    { 77, "Large theropod", "Carnivore", "Cryolophosaurus", "Early Jurassic" },
                    { 78, "Armoured dinosaur", "Herbivore", "Dacentrurus", "Late Jurassic" },
                    { 79, "Large theropod", "Carnivore", "Daspletosaurus", "Late Cretaceous" },
                    { 80, "Sauropod", "Herbivore", "Datousaurus", "Mid Jurassic" },
                    { 81, "Large theropod", "Omnivore", "Deinocheirus", "Late Cretaceous" },
                    { 82, "Small theropod", "Carnivore", "Deinonychus", "Early Cretaceous" },
                    { 83, "Large theropod", "Carnivore", "Deltadromeus", "Late Cretaceous" },
                    { 84, "Sauropod", "Herbivore", "Dicraeosaurus", "Late Jurassic" },
                    { 85, "Large theropod", "Carnivore", "Dilophosaurus", "Early Jurassic" },
                    { 86, "Sauropod", "Herbivore", "Diplodocus", "Late Jurassic" },
                    { 87, "Pachycephalosaur", "Herbivore", "Dracorex", "Late Cretaceous" },
                    { 88, "Small theropod", "Carnivore", "Dromaeosaurus", "Late Cretaceous" },
                    { 89, "Large theropod", "Omnivore", "Dromiceiomimus", "Late Cretaceous" },
                    { 90, "Small ornithopod", "Herbivore", "Dryosaurus", "Late Jurassic" },
                    { 91, "Large theropod", "Carnivore", "Dryptosaurus", "Late Cretaceous" },
                    { 92, "Large theropod", "Carnivore", "Dubreuillosaurus", "Late Jurassic" },
                    { 93, "Armoured dinosaur", "Herbivore", "Edmontonia", "Late Cretaceous" },
                    { 94, "Large ornithopod", "Herbivore", "Edmontosaurus", "Late Cretaceous" },
                    { 95, "Ceratopsian", "Herbivore", "Einiosaurus", "Late Cretaceous" },
                    { 96, "Large theropod", "Carnivore", "Elaphrosaurus", "Late Jurassic" },
                    { 97, "Armoured dinosaur", "Herbivore", "Emausaurus", "Mid Jurassic" },
                    { 98, "Large ornithopod", "Herbivore", "Eolambia", "Late Cretaceous" },
                    { 99, "Small theropod", "Carnivore", "Eoraptor", "Late Triassic" },
                    { 100, "Large theropod", "Carnivore", "Eotyrannus", "Early Cretaceous" },
                    { 101, "Large ornithopod", "Herbivore", "Equijubus", "Early Cretaceous" },
                    { 102, "Sauropod", "Herbivore", "Erketu", "Early Cretaceous" },
                    { 103, "Small theropod", "Omnivore", "Erlikosaurus", "Late Cretaceous" },
                    { 104, "Sauropod", "Herbivore", "Euhelopus", "Late Jurassic" },
                    { 105, "Armoured dinosaur", "Herbivore", "Euoplocephalus", "Late Cretaceous" },
                    { 106, "Sauropod", "Herbivore", "Europasaurus", "Late Jurassic" },
                    { 107, "Large theropod", "Carnivore", "Eustreptospondylus", "Mid Jurassic" },
                    { 108, "Large theropod", "Carnivore", "Fukuiraptor", "Early Cretaceous" },
                    { 109, "Large ornithopod", "Herbivore", "Fukuisaurus", "Early Cretaceous" },
                    { 110, "Large theropod", "Omnivore", "Gallimimus", "Late Cretaceous" },
                    { 111, "Armoured dinosaur", "Herbivore", "Gargoyleosaurus", "Late Jurassic" },
                    { 112, "Large theropod", "Omnivore", "Garudimimus", "Late Cretaceous" },
                    { 113, "Small theropod", "Carnivore", "Gasosaurus", "Mid Jurassic" },
                    { 114, "Small ornithopod", "Herbivore", "Gasparinisaura", "Late Cretaceous" },
                    { 115, "Armoured dinosaur", "Herbivore", "Gastonia", "Early Cretaceous" },
                    { 116, "Large theropod", "Carnivore", "Giganotosaurus", "Early Cretaceous" },
                    { 117, "Large ornithopod", "Herbivore", "Gilmoreosaurus", "Late Cretaceous" },
                    { 118, "Sauropod", "Herbivore", "Giraffatitan", "Late Jurassic" },
                    { 119, "Armoured dinosaur", "Herbivore", "Gobisaurus", "Early Cretaceous" },
                    { 120, "Large theropod", "Carnivore", "Gorgosaurus", "Late Cretaceous" },
                    { 121, "Pachycephalosaur", "Herbivore", "Goyocephale", "Late Cretaceous" },
                    { 122, "Ceratopsian", "Herbivore", "Graciliceratops", "Late Cretaceous" },
                    { 123, "Large ornithopod", "Herbivore", "Gryposaurus", "Late Cretaceous" },
                    { 124, "Prosauropod", "Herbivore", "Guaibasaurus", "late Triassic" },
                    { 125, "Small theropod", "Carnivore", "Guanlong", "Late Jurassic" },
                    { 126, "Large ornithopod", "Herbivore", "Hadrosaurus", "Late Cretaceous" },
                    { 127, "Small theropod", "Omnivore", "Hagryphus", "Late Cretaceous" },
                    { 128, "Sauropod", "Herbivore", "Haplocanthosaurus", "Late Jurassic" },
                    { 129, "Small theropod", "Omnivore", "Harpymimus", "Early Cretaceous" },
                    { 130, "Early dinosaur", "Carnivore", "Herrerasaurus", "Late Triassic" },
                    { 131, "Armoured dinosaur", "Herbivore", "Hesperosaurus", "Late Jurassic" },
                    { 132, "Small ornithischian", "Herbivore", "Heterodontosaurus", "Early Jurassic" },
                    { 133, "Small theropod", "Omnivore", "Heyuannia", "Late Cretaceous" },
                    { 134, "Pachycephalosaur", "Herbivore", "Homalocephale", "Late Cretaceous" },
                    { 135, "Armoured dinosaur", "Herbivore", "Huayangosaurus", "Mid Jurassic" },
                    { 136, "Armoured dinosaur", "Herbivore", "Hylaeosaurus", "Early Cretaceous" },
                    { 137, "Large ornithopod", "Herbivore", "Hypacrosaurus", "Late Cretaceous" },
                    { 138, "Small ornithopod", "Herbivore", "Hypsilophodon", "Early Cretaceous" },
                    { 139, "Large ornithopod", "Herbivore", "Iguanodon", "Early Cretaceous" },
                    { 140, "Large theropod", "Carnivore", "Indosuchus", "Late Cretaceous" },
                    { 141, "Large theropod", "Carnivore", "Irritator", "Early Cretaceous" },
                    { 142, "Sauropod", "Herbivore", "Isisaurus", "Late Cretaceous" },
                    { 143, "Sauropod", "Herbivore", "Janenschia", "Late Jurassic" },
                    { 144, "Large ornithopod", "Herbivore", "Jaxartosaurus", "Late Cretaceous" },
                    { 145, "Prosauropod", "Herbivore", "Jingshanosaurus", "Early Jurassic" },
                    { 146, "Large ornithopod", "Herbivore", "Jinzhousaurus", "Early Cretaceous" },
                    { 147, "Sauropod", "Herbivore", "Jobaria", "Early Cretaceous" },
                    { 148, "Small theropod", "Carnivore", "Juravenator", "Late Jurassic" },
                    { 149, "Armoured dinosaur", "Herbivore", "Kentrosaurus", "Late Jurassic" },
                    { 150, "Small theropod", "Omnivore", "Khaan", "Late Cretaceous" },
                    { 151, "Sauropod", "Herbivore", "Kotasaurus", "Early Jurassic" },
                    { 152, "Large ornithopod", "Herbivore", "Kritosaurus", "Late Cretaceous" },
                    { 153, "Large ornithopod", "Herbivore", "Lambeosaurus", "Late Cretaceous" },
                    { 154, "Sauropod", "Herbivore", "Lapparentosaurus", "Mid Jurassic" },
                    { 155, "Small ornithopod", "Herbivore", "Leaellynasaura", "Early Cretaceous" },
                    { 156, "Ceratopsian", "Herbivore", "Leptoceratops", "Late Cretaceous" },
                    { 157, "Small ornithischian", "Herbivore", "Lesothosaurus", "Early Jurassic" },
                    { 158, "Ceratopsian", "Herbivore", "Liaoceratops", "Early Cretaceous" },
                    { 159, "Sauropod", "Herbivore", "Ligabuesaurus", "Early Cretaceous" },
                    { 160, "Small theropod", "Carnivore", "Liliensternus", "Late Triassic" },
                    { 161, "Large ornithopod", "Herbivore", "Lophorhothon", "Late Cretaceous" },
                    { 162, "Large theropod", "Carnivore", "Lophostropheus", "Early Jurassic" },
                    { 163, "Prosauropod", "Herbivore", "Lufengosaurus", "Early Jurassic" },
                    { 164, "Large ornithopod", "Herbivore", "Lurdusaurus", "Early Cretaceous" },
                    { 165, "Small ornithischian", "Herbivore", "Lycorhinus", "Late Triassic" },
                    { 166, "Sauropod", "Herbivore", "Magyarosaurus", "Late Cretaceous" },
                    { 167, "Large ornithopod", "Herbivore", "Maiasaura", "Late Cretaceous" },
                    { 168, "Large theropod", "Carnivore", "Majungasaurus", "Late Cretaceous" },
                    { 169, "Sauropod", "Herbivore", "Malawisaurus", "Early Cretaceous" },
                    { 170, "Sauropod", "Herbivore", "Mamenchisaurus", "Late Jurassic" },
                    { 171, "Large theropod", "Carnivore", "Mapusaurus", "Late Cretaceous" },
                    { 172, "Large theropod", "Carnivore", "Marshosaurus", "Late Jurassic" },
                    { 173, "Small theropod", "Carnivore", "Masiakasaurus", "Late Cretaceous" },
                    { 174, "Prosauropod", "Omnivore", "Massospondylus", "Early Jurassic" },
                    { 175, "Sauropod", "Herbivore", "Maxakalisaurus", "Late Cretaceous" },
                    { 176, "Large theropod", "Carnivore", "Megalosaurus", "Mid Jurassic" },
                    { 177, "Prosauropod", "Omnivore", "Melanorosaurus", "Late Triassic" },
                    { 178, "Large theropod", "Carnivore", "Metriacanthosaurus", "Late Jurassic" },
                    { 179, "Ceratopsian", "Herbivore", "Microceratus", "Late Cretaceous" },
                    { 180, "Ceratopsian", "Herbivore", "Micropachycephalosaurus", "Late Cretaceous" },
                    { 181, "Small theropod", "Carnivore", "Microraptor", "Early Cretaceous" },
                    { 182, "Armoured dinosaur", "Herbivore", "Minmi", "Early Cretaceous" },
                    { 183, "Large theropod", "Carnivore", "Monolophosaurus", "Mid Jurassic" },
                    { 184, "Small theropod", "", "Mononykus", "Late Cretaceous" },
                    { 185, "Prosauropod", "Herbivore", "Mussaurus", "Late Triassic" },
                    { 186, "Large ornithopod", "Herbivore", "Muttaburrasaurus", "Early Cretaceous" },
                    { 187, "Large theropod", "Omnivore", "Nanshiungosaurus", "Late Cretaceous" },
                    { 188, "Ceratopsian", "Herbivore", "Nedoceratops", "Late Cretaceous" },
                    { 189, "Sauropod", "Herbivore", "Nemegtosaurus", "Late Cretaceous" },
                    { 190, "Large theropod", "Carnivore", "Neovenator", "Early Cretaceous" },
                    { 191, "Sauropod", "Herbivore", "Neuquenosaurus", "Late Cretaceous" },
                    { 192, "Sauropod", "Herbivore", "Nigersaurus", "Early Cretaceous" },
                    { 193, "Large ornithopod", "Herbivore", "Nipponosaurus", "Late Cretaceous" },
                    { 194, "Small theropod", "Carnivore", "Noasaurus", "Late Cretaceous" },
                    { 195, "Armoured dinosaur", "Herbivore", "Nodosaurus", "Early Cretaceous" },
                    { 196, "Small theropod", "Omnivore", "Nomingia", "Late Cretaceous" },
                    { 197, "Large theropod", "Omnivore", "Nothronychus", "Late Cretaceous" },
                    { 198, "Small theropod", "Carnivore", "Nqwebasaurus", "Mid Jurassic" },
                    { 199, "Sauropod", "Herbivore", "Omeisaurus", "Mid Jurassic" },
                    { 200, "Sauropod", "Herbivore", "Opisthocoelicaudia", "Late Cretaceous" },
                    { 201, "Small theropod", "Carnivore", "Ornitholestes", "late Jurassic" },
                    { 202, "Large theropod", "Omnivore", "Ornithomimus", "Late Cretaceous" },
                    { 203, "Small ornithopod", "Herbivore", "Orodromeus", "Late Cretaceous" },
                    { 204, "Small ornithopod", "Herbivore", "Oryctodromeus", "Late Cretaceous" },
                    { 205, "Small ornithischian", "Herbivore", "Othnielia", "late Jurassic" },
                    { 206, "Large ornithopod", "Herbivore", "Ouranosaurus", "Early Cretaceous" },
                    { 207, "Small theropod", "Omnivore", "Oviraptor", "Late Cretaceous" },
                    { 208, "Pachycephalosaur", "Herbivore", "Pachycephalosaurus", "Late Cretaceous" },
                    { 209, "Ceratopsian", "Herbivore", "Pachyrhinosaurus", "Late Cretaceous" },
                    { 210, "Armoured dinosaur", "Herbivore", "Panoplosaurus", "Late Cretaceous" },
                    { 211, "Prosauropod", "Herbivore", "Pantydraco", "Early Jurassic" },
                    { 212, "Sauropod", "Herbivore", "Paralititan", "Late Cretaceous" },
                    { 213, "Large ornithopod", "Herbivore", "Parasaurolophus", "Late Cretaceous" },
                    { 214, "Small ornithopod", "Herbivore", "Parksosaurus", "Late Cretaceous" },
                    { 215, "Sauropod", "Herbivore", "Patagosaurus", "Mid Jurassic" },
                    { 216, "Small theropod", "Carnivore", "Pelicanimimus", "Early Cretaceous" },
                    { 217, "Sauropod", "Herbivore", "Pelorosaurus", "Early Cretaceous" },
                    { 218, "Ceratopsian", "", "Pentaceratops", "" },
                    { 219, "Large theropod", "Carnivore", "Piatnitzkysaurus", "Late Jurassic" },
                    { 220, "Armoured dinosaur", "Herbivore", "Pinacosaurus", "Late Cretaceous" },
                    { 221, "Prosauropod", "Herbivore", "Plateosaurus", "Late Triassic" },
                    { 222, "Small theropod", "Carnivore", "Podokesaurus", "Mid Jurassic" },
                    { 223, "Large theropod", "Carnivore", "Poekilopleuron", "Mid Jurassic" },
                    { 224, "Armoured dinosaur", "Herbivore", "Polacanthus", "Early Cretaceous" },
                    { 225, "Pachycephalosaur", "Herbivore", "Prenocephale", "Late Cretaceous" },
                    { 226, "Large ornithopod", "Herbivore", "Probactrosaurus", "Early Cretaceous" },
                    { 227, "Small theropod", "Carnivore", "Proceratosaurus", "Mid Jurassic" },
                    { 228, "Small theropod", "Carnivore", "Procompsognathus", "Late Triassic" },
                    { 229, "Large ornithopod", "Herbivore", "Prosaurolophus", "Late Cretaceous" },
                    { 230, "Small theropod", "Carnivore", "Protarchaeopteryx", "Early Cretaceous" },
                    { 231, "Ceratopsian", "Herbivore", "Protoceratops", "Late Cretaceous" },
                    { 232, "Large ornithopod", "Herbivore", "Protohadros", "Late Cretaceous" },
                    { 233, "Ceratopsian", "Herbivore", "Psittacosaurus", "Early Cretaceous" },
                    { 234, "Sauropod", "Herbivore", "Quaesitosaurus", "Late Cretaceous" },
                    { 235, "Sauropod", "Herbivore", "Rebbachisaurus", "Early Cretaceous" },
                    { 236, "Large ornithopod", "Herbivore", "Rhabdodon", "Mid Jurassic" },
                    { 237, "Sauropod", "Herbivore", "Rhoetosaurus", "Mid Jurassic" },
                    { 238, "Small theropod", "Omnivore", "Rinchenia", "Late Cretaceous" },
                    { 239, "Prosauropod", "Herbivore", "Riojasaurus", "Late Triassic" },
                    { 240, "Large theropod", "Carnivore", "Rugops", "Late Cretaceous" },
                    { 241, "Armoured dinosaur", "Herbivore", "Saichania", "Late Cretaceous" },
                    { 242, "Sauropod", "Herbivore", "Saltasaurus", "Late Cretaceous" },
                    { 243, "Small theropod", "Carnivore", "Sarcosaurus", "Early Jurassic" },
                    { 244, "Large ornithopod", "Herbivore", "Saurolophus", "Late Cretaceous" },
                    { 245, "Armoured dinosaur", "Herbivore", "Sauropelta", "Early Cretaceous" },
                    { 246, "Large theropod", "Carnivore", "Saurophaganax", "Late Jurassic" },
                    { 247, "Small theropod", "Carnivore", "Saurornithoides", "Late Cretaceous" },
                    { 248, "Armoured dinosaur", "Herbivore", "Scelidosaurus", "Early Jurassic" },
                    { 249, "Armoured dinosaur", "Herbivore", "Scutellosaurus", "Early Jurassic" },
                    { 250, "Large ornithopod", "Herbivore", "Secernosaurus", "Late Cretaceous" },
                    { 251, "Small theropod", "Carnivore", "Segisaurus", "Mid Jurassic" },
                    { 252, "Large theropod", "Carnivore", "Segnosaurus", "Late Cretaceous" },
                    { 253, "Armoured dinosaur", "Herbivore", "Shamosaurus", "Early Cretaceous" },
                    { 254, "Small theropod", "Carnivore", "Shanag", "Early Cretaceous" },
                    { 255, "Large ornithopod", "Herbivore", "Shantungosaurus", "Late Cretaceous" },
                    { 256, "Sauropod", "Herbivore", "Shunosaurus", "Mid Jurassic" },
                    { 257, "Small theropod", "Omnivore", "Shuvuuia", "Late Cretaceous" },
                    { 258, "Armoured dinosaur", "Herbivore", "Silvisaurus", "Early Cretaceous" },
                    { 259, "Small theropod", "Carnivore", "Sinocalliopteryx", "Early Cretaceous" },
                    { 260, "Small theropod", "Carnivore", "Sinornithosaurus", "Early Cretaceous" },
                    { 261, "Small theropod", "Carnivore", "Sinosauropteryx", "Early Cretaceous" },
                    { 262, "Small theropod", "Carnivore", "Sinovenator", "Early Cretaceous" },
                    { 263, "Large theropod", "Carnivore", "Sinraptor", "Mid Jurassic" },
                    { 264, "Sauropod", "Herbivore", "Sonidosaurus", "Late Cretaceous" },
                    { 265, "Large theropod", "Carnivore", "Spinosaurus", "Late Cretaceous" },
                    { 266, "Early dinosaur", "Carnivore", "Staurikosaurus", "Late Triassic" },
                    { 267, "Pachycephalosaur", "Herbivore", "Stegoceras", "Late Cretaceous" },
                    { 268, "Armoured dinosaur", "Herbivore", "Stegosaurus", "Late Jurassic" },
                    { 269, "Ceratopsian", "Herbivore", "Stenopelix", "Early Cretaceous" },
                    { 270, "Small theropod", "Omnivore", "Struthiomimus", "Late Cretaceous" },
                    { 271, "Armoured dinosaur", "Herbivore", "Struthiosaurus", "Late Cretaceous" },
                    { 272, "Ceratopsian", "Herbivore", "Styracosaurus", "Late Cretaceous" },
                    { 273, "Large theropod", "Carnivore", "Suchomimus", "Early Cretaceous" },
                    { 274, "Sauropod", "Herbivore", "Supersaurus", "Early Cretaceous" },
                    { 275, "Armoured dinosaur", "Herbivore", "Talarurus", "Late Cretaceous" },
                    { 276, "Large ornithopod", "Herbivore", "Tanius", "Late Cretaceous" },
                    { 277, "Large theropod", "Carnivore", "Tarbosaurus", "Late Cretaceous" },
                    { 278, "Armoured dinosaur", "Herbivore", "Tarchia", "Late Cretaceous" },
                    { 279, "Large ornithopod", "Herbivore", "Telmatosaurus", "Late Cretaceous" },
                    { 280, "Large ornithopod", "Herbivore", "Tenontosaurus", "Early Cretaceous" },
                    { 281, "Prosauropod", "Herbivore", "Thecodontosaurus", "Late Triassic" },
                    { 282, "Large theropod", "Carnivore", "Therizinosaurus", "Late Cretaceous" },
                    { 283, "Small ornithopod", "Herbivore", "Thescelosaurus", "Late Cretaceous" },
                    { 284, "Ceratopsian", "Herbivore", "Torosaurus", "Late Cretaceous" },
                    { 285, "Large theropod", "Carnivore", "Torvosaurus", "Late Jurassic" },
                    { 286, "Ceratopsian", "Herbivore", "Triceratops", "Late Cretaceous" },
                    { 287, "Small theropod", "Carnivore", "Troodon", "Late Cretaceous" },
                    { 288, "Armoured dinosaur", "Herbivore", "Tsagantegia", "Late Cretaceous" },
                    { 289, "Large ornithopod", "Herbivore", "Tsintaosaurus", "Late Cretaceous" },
                    { 290, "Armoured dinosaur", "Herbivore", "Tuojiangosaurus", "Late Jurassic" },
                    { 291, "Pachycephalosaur", "Herbivore", "Tylocephale", "Late Cretaceous" },
                    { 292, "Large theropod", "Carnivore", "Tyrannosaurus", "Late Cretaceous" },
                    { 293, "Ceratopsian", "Herbivore", "Udanoceratops", "Late Cretaceous" },
                    { 294, "Small theropod", "Carnivore", "Unenlagia", "Late Cretaceous" },
                    { 295, "Small theropod", "Carnivore", "Urbacodon", "Late Cretaceous" },
                    { 296, "Large theropod", "Carnivore", "Utahraptor", "Early Cretaceous" },
                    { 297, "Small ornithopod", "Herbivore", "Valdosaurus", "Early Cretaceous" },
                    { 298, "Small theropod", "Carnivore", "Velociraptor", "Late Cretaceous" },
                    { 299, "Sauropod", "Herbivore", "Vulcanodon", "Early Jurassic" },
                    { 300, "Small ornithopod", "Herbivore", "Yandusaurus", "Mid Jurassic" },
                    { 301, "Large theropod", "Carnivore", "Yangchuanosaurus", "Late Jurassic" },
                    { 302, "Prosauropod", "Herbivore", "Yimenosaurus", "Early Jurassic" },
                    { 303, "Armoured dinosaur", "Herbivore", "Yingshanosaurus", "Late Jurassic" },
                    { 304, "Ceratopsian", "Herbivore", "Yinlong", "Mid Jurassic" },
                    { 305, "Sauropod", "Herbivore", "Yuanmousaurus", "Mid Jurassic" },
                    { 306, "Prosauropod", "Omnivore", "Yunnanosaurus", "Early Jurassic" },
                    { 307, "Small ornithopod", "Herbivore", "Zalmoxes", "Late Cretaceous" },
                    { 308, "Small ornithopod", "Herbivore", "Zephyrosaurus", "Early Cretaceous" },
                    { 309, "Ceratopsian", "Herbivore", "Zuniceratops", "Late Cretaceous" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Dinosaurs",
                keyColumn: "Id",
                keyValue: 309);
        }
    }
}
