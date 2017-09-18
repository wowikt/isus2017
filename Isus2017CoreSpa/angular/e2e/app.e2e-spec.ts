import { Isus2017CoreSpaTemplatePage } from './app.po';

describe('abp-project-name-template App', function() {
  let page: Isus2017CoreSpaTemplatePage;

  beforeEach(() => {
    page = new Isus2017CoreSpaTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
